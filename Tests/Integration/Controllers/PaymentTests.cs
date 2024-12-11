﻿public class PaymentTests(IMediator mediator, IMessageRequests messageRequests, ILoggerFactory loggerFactory)
{
    private readonly ILogger _logger = loggerFactory.CreateLogger<PaymentScheduleTests>();

    [Fact]
    public async Task Send_Payment_To_CAS()
    {
        var startTime = DateTime.Now;

        var configurationQuery = new ConfigurationQuery();
        configurationQuery.StateCode = StateCode.Active;
        configurationQuery.Group = "CAS";
        var configs = await mediator.Send(configurationQuery);

        var getKeyValueCommand = new GetKeyValueCommand(configs, "ClientKey", "CAS", null);
        var clientKey = await mediator.Send(getKeyValueCommand);
        getKeyValueCommand = new GetKeyValueCommand(configs, "ClientId", "CAS", null);
        var clientId = await mediator.Send(getKeyValueCommand);
        getKeyValueCommand = new GetKeyValueCommand(configs, "InterfaceUrl", "CAS", null);
        var url = await mediator.Send(getKeyValueCommand);

        var paymentQuery = new PaymentQuery();
        paymentQuery.IncludeChildren = true;
        paymentQuery.StateCode = StateCode.Active;
        paymentQuery.StatusCode = PaymentStatusCode.Waiting;
        paymentQuery.BeforeDate = DateTime.Now;
        var payments = await mediator.Send(paymentQuery);

        foreach (var postImageEntity in payments)
        {
            string userMessage = string.Empty;
            HttpClient httpClient = null;
            bool isError = false;
            _logger.LogInformation("Processing Payment: " + postImageEntity.Name);
            if ((DateTime.Now - startTime).TotalSeconds >= 100) //2-limit timer
            {
                break;
            }

            try
            {
                ArgumentNullException.ThrowIfNull(postImageEntity.Payee, "Payee lookup is missing on the payment.");
                ArgumentNullException.ThrowIfNull(postImageEntity.Total, "Payment Total is missing on the payment.");
                ArgumentNullException.ThrowIfNull(postImageEntity.Date, "CAS Payment Date is missing on the payment.");

                //messageRequests.SetState(Vsd_Payment.EntityLogicalName, postImageEntity.Id, (int)StateCode.Active, (int)PaymentStatusCode.Sending); //Sending

                var invoices = await GenerateInvoice(configs, postImageEntity);
                var jsonRequest = JsonConvert.SerializeObject(invoices);

                //Log.AppendLine("Sending Json: " + jsonRequest.ToString());
                //httpClient = new HttpClient();
                //httpClient.DefaultRequestHeaders.Add("clientID", clientId);
                //httpClient.DefaultRequestHeaders.Add("secret", clientKey);
                //httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //httpClient.BaseAddress = new Uri(url);
                //httpClient.Timeout = new TimeSpan(1, 0, 0);  // 1 hour timeout 

                //HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url + "/api/CASAPTransaction");
                //request.Content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

                //HttpResponseMessage response = httpClient.SendAsync(request).Result;

                //            if (response.StatusCode == HttpStatusCode.OK)
                //            {
                //                var httpResponse = response.Content.ReadAsStringAsync().Result;

                //                var jsonReader = System.Runtime.Serialization.Json.JsonReaderWriterFactory.CreateJsonReader(Encoding.UTF8.GetBytes(httpResponse), new XmlDictionaryReaderQuotas());

                //                var root = XElement.Load(jsonReader);
                //                if (root.Element("CAS-Returned-Messages") != null)
                //                {
                //                    var casReturnedMessages = root.Element("CAS-Returned-Messages");
                //                    if (casReturnedMessages != null)
                //                    {
                //                        if (!(casReturnedMessages.Value.Equals("SUCCEEDED", StringComparison.InvariantCultureIgnoreCase) | casReturnedMessages.Value.Contains("Duplicate Submission")))
                //                            throw new Exception(casReturnedMessages.Value + "\r\n" + jsonRequest);
                //                    }
                //                    else
                //                        throw new Exception(httpResponse + "\r\n" + jsonRequest);
                //                }
                //                else
                //                    throw new Exception(httpResponse + "\r\n" + jsonRequest);
                //            }
                //            else
                //                throw new Exception(response.StatusCode.ToString() + "\r\n" + jsonRequest);
            }
            catch (Exception ex1)
            {
                isError = true;
                userMessage = ex1.Message;
                _logger.LogError(ex1.Message);
            }
            finally
            {
                //var updatePayment = new Payment();
                //updatePayment.Id = postImageEntity.Id;

                //if (!string.IsNullOrEmpty(userMessage))
                //    updatePayment.CasResponse = (userMessage.Length >= 2000 ? userMessage.Substring(0, 1998) : userMessage);

                //if (isError)
                //    updatePayment.StatusCode = PaymentStatusCode.Failed;
                //else
                //{
                //    updatePayment.Date = DateTime.Now;
                //    updatePayment.StatusCode = PaymentStatusCode.Sent;
                //}

                // TODO
                //OrgService.Update(updatePayment);

                if (httpClient != null)
                    httpClient.Dispose();

                _logger.LogInformation(postImageEntity.Name + " END.");
            }
        }
    }

    private async Task<CasApTransactionInvoice> GenerateInvoice(IEnumerable<Configuration> configs, Payment paymentEntity)
    {
        ArgumentNullException.ThrowIfNull(paymentEntity.Invoices, "Invoice is missing.");
        if (paymentEntity.Invoices.Count() != 1)
            throw new Exception("Payment is associated to multiple invoices.");

        #region Payee Details
        string supplierNumber = string.Empty;
        int siteNumber = int.MinValue;
        string firstName = string.Empty;
        string lastName = string.Empty;
        string addressLine1 = string.Empty;
        string addressLine2 = string.Empty;
        string addressLine3 = string.Empty;
        string city = string.Empty;
        string province = string.Empty;
        string country = string.Empty;
        string postalCode = string.Empty;
        var programUnit = ProgramUnit.Cvap;
        Invoice invoiceEntity = paymentEntity.Invoices.Single();
        string methodOfPayment = "GEN CHQ";
        string accountNumber = string.Empty;
        string transitNumber = string.Empty;
        string institutionNumber = string.Empty;
        string emailAddress = string.Empty;
        bool isBlockSupplier = false;
        var payeeLookup = paymentEntity.Payee;

        ArgumentNullException.ThrowIfNull(invoiceEntity.InvoiceDate, "Invoice Date is missing.");
        ArgumentNullException.ThrowIfNull(invoiceEntity.Name, "Invoice Number is missing.");
        //ArgumentNullException.ThrowIfNull(invoiceEntity.ProgramUnit, "Invoice Program Unit is missing.");

        if (invoiceEntity.MethodOfPayment == MethodOfPayment.Eft)
            methodOfPayment = "GEN EFT";

        var programUnitConfigs = configs.Where(x => x.ProgramUnit == programUnit).ToList();

        var getKeyValueCommand = new GetKeyValueCommand(programUnitConfigs, "GSTDistributionAccount", "CAS", programUnit);
        var gstDistributionAccount = await mediator.Send(getKeyValueCommand);

        if (payeeLookup.SchemaName.Equals(Database.Model.Account.EntityLogicalName, StringComparison.InvariantCultureIgnoreCase))
        {
            var accountEntity = await mediator.Send(new FindAccountQuery { Id = payeeLookup.Id });

            ArgumentNullException.ThrowIfNull(accountEntity.Name, "Account Name is missing.");
            if (string.IsNullOrEmpty(accountEntity.AccountNumber))
            {
                if (programUnit == ProgramUnit.Cvap || programUnit == ProgramUnit.Vsu || programUnit == ProgramUnit.Rest)
                {
                    isBlockSupplier = true;
                    accountEntity.AccountNumber = await mediator.Send(new GetKeyValueCommand(programUnitConfigs, "BlockSupplierNumber", "CAS", programUnit));
                }
                else
                    throw new Exception("Vendor/Account Number on Service Provider is missing.");
            }
            if (accountEntity.SupplierSiteNumber.HasValue)
            {
                if (programUnit == ProgramUnit.Cvap || programUnit == ProgramUnit.Vsu || programUnit == ProgramUnit.Rest)
                {
                    isBlockSupplier = true;
                    accountEntity.SupplierSiteNumber = int.Parse(await mediator.Send(new GetKeyValueCommand(programUnitConfigs, "SupplierSiteNumber", "CAS", programUnit)));
                }
            }

            supplierNumber = accountEntity.AccountNumber;
            if (accountEntity.SupplierSiteNumber != null)
                siteNumber = accountEntity.SupplierSiteNumber.Value;

            if (programUnit == ProgramUnit.Rest && !string.IsNullOrEmpty(accountEntity.RestChequeName) && methodOfPayment.Equals("GEN CHQ", StringComparison.InvariantCultureIgnoreCase)) //REST and CHQ
                firstName = accountEntity.RestChequeName;
            else
                firstName = accountEntity.Name;

            if ( //Payment Address
                accountEntity.Address2Code.HasValue && 
                accountEntity.Address2Code.Value == AccountAddress2Code.PaymentAddress && 
                accountEntity.Addresses != null &&
                accountEntity.Addresses.Length > 1 &&
                !string.IsNullOrEmpty(accountEntity.Addresses[1].AddressLine1)
            ){
                addressLine1 = accountEntity.Addresses[1].AddressLine1 ?? string.Empty;
                addressLine2 = accountEntity.Addresses[1].AddressLine2 ?? string.Empty;
                addressLine3 = accountEntity.Addresses[1].AddressLine3 ?? string.Empty;
                city = accountEntity.Addresses[1].City ?? string.Empty;
                province = accountEntity.Addresses[1].StateOrProvince ?? string.Empty;
                country = accountEntity.Addresses[1].Country ?? string.Empty;
                postalCode = accountEntity.Addresses[1].PostalCode ?? string.Empty;
            }
            else
            {
                if (accountEntity.Addresses != null && accountEntity.Addresses.Length > 0)
                {
                    addressLine1 = accountEntity.Addresses[0].AddressLine1 ?? string.Empty;
                    addressLine2 = accountEntity.Addresses[0].AddressLine2 ?? string.Empty;
                    addressLine3 = accountEntity.Addresses[0].AddressLine3 ?? string.Empty;
                    city = accountEntity.Addresses[0].City ?? string.Empty;
                    province = accountEntity.Addresses[0].StateOrProvince ?? string.Empty;
                    country = accountEntity.Addresses[0].Country ?? string.Empty;
                    postalCode = accountEntity.Addresses[0].PostalCode ?? string.Empty;
                }
            }

            accountNumber = accountEntity.AccountNumber ?? string.Empty;
            transitNumber = accountEntity.TransitNumber ?? string.Empty;
            institutionNumber = accountEntity.InstitutionNumber ?? string.Empty;
            emailAddress = accountEntity.Emails?[0] ?? string.Empty;
        }
        else
        {
            var contactEntity = await mediator.Send(new FindContactQuery { Id = payeeLookup.Id });

            //ArgumentNullException.ThrowIfNull(contactEntity.ContactRole, "Contact Role is missing.");
            if (string.IsNullOrEmpty(contactEntity.AccountNumber))
            {
                if (programUnit == ProgramUnit.Cvap || programUnit == ProgramUnit.Vsu || programUnit == ProgramUnit.Rest)
                {
                    isBlockSupplier = true;
                    contactEntity.AccountNumber = await mediator.Send(new GetKeyValueCommand(programUnitConfigs, "BlockSupplierNumber", "CAS", programUnit));
                }
                else
                    throw new Exception("Vendor/Account Number on Service Provider is missing.");
            }
            if (contactEntity.SupplierSiteNumber == null)
            {
                if (programUnit == ProgramUnit.Cvap || programUnit == ProgramUnit.Vsu || programUnit == ProgramUnit.Rest)
                {
                    isBlockSupplier = true;
                    contactEntity.SupplierSiteNumber = int.Parse(await mediator.Send(new GetKeyValueCommand(programUnitConfigs, "SupplierSiteNumber", "CAS", programUnit)));
                }
            }

            supplierNumber = contactEntity.AccountNumber;
            if (contactEntity.SupplierSiteNumber != null)
                siteNumber = (int)contactEntity.SupplierSiteNumber;

            if (programUnit == ProgramUnit.Rest && !string.IsNullOrEmpty(contactEntity.RestChequeName) && methodOfPayment.Equals("GEN CHQ", StringComparison.InvariantCultureIgnoreCase)) //REST and CHQ
                firstName = contactEntity.RestChequeName;
            else
            {
                firstName = contactEntity.FirstName;
                lastName = contactEntity.LastName;
            }

            if (contactEntity.Addresses != null && contactEntity.Addresses.Length > 0 && !string.IsNullOrEmpty(contactEntity.Addresses[0].AddressLine1)) //Payment Address
            {
                addressLine1 = contactEntity.Addresses?[0].AddressLine1;
                addressLine2 = contactEntity.Addresses?[0].AddressLine2;
                addressLine3 = contactEntity.Addresses?[0].AddressLine3;
                city = contactEntity.Addresses?[0].City;
                province = contactEntity.Addresses?[0].StateOrProvince;
                country = contactEntity.Addresses?[0].Country;
                postalCode = contactEntity.Addresses?[0].PostalCode;
                accountNumber = contactEntity.AccountNumber;
                transitNumber = contactEntity.TransitNumber;
                institutionNumber = contactEntity.InstitutionNumber;
                emailAddress = contactEntity.Emails?[0];
            }
        }
        #endregion

        #region Invoice Details

        var invoiceDate = paymentEntity.Date;
        string invoiceNumber = invoiceEntity.Name;

        if (programUnit == ProgramUnit.Cvap && invoiceEntity.Origin != null && invoiceEntity.Origin != Origin.AutoGenerated)
        {
            if (string.IsNullOrEmpty(invoiceEntity.Validator))
                throw new Exception("Validator is missing from the invoice.");
        }

        var defaultDistributionAccount = "";
        if (programUnit == ProgramUnit.Cpu)
        {
            if (invoiceEntity.CpuInvoiceType == null)
                throw new Exception("Invoice Type is missing for CPU invoice. Unable to determine STOB.");

            if (invoiceEntity.CpuInvoiceType == CpuInvoiceType.ScheduledPayment)
            {
                if (invoiceEntity.ProgramId == null)
                    throw new Exception("Invoice Program Lookup is missing.");

                defaultDistributionAccount = await GenerateDefaultDistributionAccount(invoiceEntity.ProgramId.Value);
            }
            else if (invoiceEntity.CpuInvoiceType == CpuInvoiceType.OneTimePayment)
            {
                if (invoiceEntity.ProgramId != null)
                    defaultDistributionAccount = await GenerateDefaultDistributionAccount(invoiceEntity.ProgramId.Value);

                //if (invoiceEntity.Contains("vsd_caspaymenttype"))
                //    defaultDistributionAccount = GenerateOneTimeDistributionAccount(((EntityReference)invoiceEntity["vsd_caspaymenttype"]).Id);

                if (string.IsNullOrEmpty(defaultDistributionAccount))
                    throw new Exception("Invoice Payment Type/Program is missing.");
            }
            else
                throw new Exception("Unknown CPU Invoice Type..");
        }
        else if (programUnit == ProgramUnit.Cvap || programUnit == ProgramUnit.Vsu || programUnit == ProgramUnit.Rest)
        {
            //if (invoiceEntity.Contains("vsd_cvap_stobid"))
            //    defaultDistributionAccount = GenerateCVAPDistributionAccount(((EntityReference)invoiceEntity["vsd_cvap_stobid"]).Id);

            if (string.IsNullOrEmpty(defaultDistributionAccount))
                throw new Exception("CVAP STOB is missing.");
        }
        else
            throw new Exception(string.Format("STOB information is not setup for Program Unit '{0}'.", (ProgramUnit)programUnit));

        if (string.IsNullOrEmpty(defaultDistributionAccount))
            throw new Exception("Default Distribution Account is missing.");

        var invoiceLineDetailQuery = new InvoiceLineDetailQuery();
        invoiceLineDetailQuery.InvoiceId = invoiceEntity.Id;
        invoiceLineDetailQuery.StateCode = StateCode.Active;
        invoiceLineDetailQuery.Approved = YesNo.Yes;
        var invoiceLineDetails = await mediator.Send(invoiceLineDetailQuery);
        var jsonInvoiceLineDetails = new List<CasApTransactionInvoiceLineDetail>();

        int j = 0;
        if (invoiceLineDetails != null && invoiceLineDetails.Any()) 
        {
            foreach (var invoiceLineDetail in invoiceLineDetails)
            {
                if (invoiceLineDetail.AmountCalculated == null)
                    throw new Exception("Invoice Line Item Sub Total Amount is missing.");
                if (invoiceLineDetail.TaxExemption == null)
                    throw new Exception("Invoice Line Item Tax is missing.");
                if (invoiceLineDetail.TotalAmount == null)
                    throw new Exception("Invoice Line Item Total Amount is missing.");

                j = j + 1;
                var lineDetail = new CasApTransactionInvoiceLineDetail()
                {
                    InvoiceLineNumber = j,
                    InvoiceLineType = "Item",
                    LineCode = paymentEntity.LineCode?.ToString(),
                    InvoiceLineAmount = (decimal)invoiceLineDetail.AmountCalculated,
                    DefaultDistributionAccount = defaultDistributionAccount
                };
                jsonInvoiceLineDetails.Add(lineDetail);

                j = j + 1;
                if (invoiceLineDetail.TaxExemption == TaxExemption.PstOnly)
                {
                    lineDetail.InvoiceLineAmount = (decimal)invoiceLineDetail.TotalAmount - (decimal)invoiceLineDetail.AmountCalculated;
                    jsonInvoiceLineDetails.Add(lineDetail);
                }
                else if (invoiceLineDetail.TaxExemption == TaxExemption.GstOnly)
                {
                    lineDetail.InvoiceLineAmount = (decimal)invoiceLineDetail.TotalAmount - (decimal)invoiceLineDetail.AmountCalculated;
                    lineDetail.DefaultDistributionAccount = gstDistributionAccount;
                    jsonInvoiceLineDetails.Add(lineDetail);
                }
                else if (invoiceLineDetail.TaxExemption == TaxExemption.AllTax) //GST and PST
                {
                    if (invoiceLineDetail.GstAmount == null)
                        throw new Exception("GST amount is missing.");

                    lineDetail.InvoiceLineAmount = (decimal)invoiceLineDetail.GstAmount;
                    lineDetail.DefaultDistributionAccount = gstDistributionAccount;
                    jsonInvoiceLineDetails.Add(lineDetail);

                    j = j + 1;
                    lineDetail.InvoiceLineAmount = (decimal)(invoiceLineDetail.TotalAmount - invoiceLineDetail.AmountCalculated + invoiceLineDetail.GstAmount);
                    lineDetail.DefaultDistributionAccount = defaultDistributionAccount;
                    jsonInvoiceLineDetails.Add(lineDetail);
                }
            }
        }
        else
        {
            var lineDetail = new CasApTransactionInvoiceLineDetail()
            {
                InvoiceLineNumber = 1,
                InvoiceLineType = "Item",
                LineCode = paymentEntity.LineCode.ToString(),
                InvoiceLineAmount = (decimal)paymentEntity.Total,
                DefaultDistributionAccount = defaultDistributionAccount
            };
            jsonInvoiceLineDetails.Add(lineDetail);
        }

        #endregion

        #region Mandatory Field Validations

        if (string.IsNullOrEmpty(supplierNumber))
            throw new Exception("Vendor Number is missing.");

        if (methodOfPayment.Equals("GEN EFT", StringComparison.InvariantCultureIgnoreCase) && isBlockSupplier)
        {
            if (string.IsNullOrEmpty(accountNumber))
                throw new Exception("Account # is missing.");
            if (string.IsNullOrEmpty(transitNumber))
                throw new Exception("Transit # is missing.");
            if (string.IsNullOrEmpty(institutionNumber))
                throw new Exception("Institution # is missing.");
        }

        if (siteNumber == int.MinValue)
            throw new Exception("Supplier Site Number is missing.");
        if (paymentEntity.Total == null)
            throw new Exception("Invoice Amount is missing.");
        if (invoiceDate == DateTime.MinValue)
            throw new Exception("Invoice Date is missing.");
        if (paymentEntity.GlDate == DateTime.MinValue)
            throw new Exception("GL Date is missing.");

        #endregion

        string invoiceType = await mediator.Send(new GetKeyValueCommand(configs, "InvoiceType", "CAS", null));
        string remittanceCode = await mediator.Send(new GetKeyValueCommand(configs, "RemittanceCode", "CAS", null));
        string batchName = await mediator.Send(new GetKeyValueCommand(configs, "BatchName", "CAS", null));
        string currencyCode = await mediator.Send(new GetKeyValueCommand(configs, "CurrencyCode", "CAS", null));

        var result = new CasApTransactionInvoice
        {
            //Mandatory values
            IsBlockSupplier = isBlockSupplier,
            InvoiceType = invoiceType,
            SupplierNumber = supplierNumber,
            SupplierSiteNumber = siteNumber,
            InvoiceDate = invoiceDate,
            InvoiceNumber = invoiceNumber,
            InvoiceAmount = (decimal)paymentEntity.Total,
            PayGroup = methodOfPayment,
            DateInvoiceReceived = invoiceDate,
            RemittanceCode = remittanceCode,
            SpecialHandling = false,
            Terms = paymentEntity.Terms?.ToString(),
            GLDate = paymentEntity.GlDate,
            InvoiceBatchName = batchName,

            //Optional Value
            QualifiedReceiver = paymentEntity.Owner.SchemaName,
            PaymentAdviceComments = paymentEntity.AdviceComments ?? "",
            RemittanceMessage1 = paymentEntity.RemittanceMessage1 ?? "",
            RemittanceMessage2 = paymentEntity.RemittanceMessage2 ?? "",
            RemittanceMessage3 = paymentEntity.RemittanceMessage3 ?? "",
            CurrencyCode = currencyCode
        };

        result.InvoiceLineDetails = jsonInvoiceLineDetails;

        if (methodOfPayment.Equals("GEN EFT", StringComparison.InvariantCultureIgnoreCase))
        {
            if (isBlockSupplier)
            {
                result.AccountNumber = accountNumber;
                result.TransitNumber = transitNumber;
                result.InstitutionNumber = institutionNumber;

                if (paymentEntity.EftAdvice != null)
                {
                    if (paymentEntity.EftAdvice == EftAdvice.Email)
                    {
                        if (string.IsNullOrEmpty(emailAddress))
                            throw new Exception("Email Address on the Payee is missing.");

                        result.EmailAddress = emailAddress;
                        result.EFTAdvice = "E";
                    }
                    else if (paymentEntity.EftAdvice == EftAdvice.Mail)
                    {
                        result.EFTAdvice = "P";
                        List<string> nameLines = new List<string>();
                        if (!string.IsNullOrEmpty(firstName))
                            nameLines.Add(firstName);
                        if (!string.IsNullOrEmpty(lastName))
                            nameLines.Add(lastName);
                        if (nameLines.Count > 0)
                        {
                            result.NameLine1 = string.Join(" ", nameLines);
                            if (result.NameLine1.Length > 40)
                                throw new Exception(string.Format("'{0}' name exceeded 40 character limit.."));
                        }
                        if (!string.IsNullOrEmpty(addressLine1))
                            result.AddressLine1 = addressLine1;
                        if (!string.IsNullOrEmpty(addressLine2))
                            result.AddressLine2 = addressLine2;
                        if (!string.IsNullOrEmpty(addressLine3))
                            result.AddressLine3 = addressLine3;
                        if (!string.IsNullOrEmpty(city))
                            result.City = city;
                        if (!string.IsNullOrEmpty(country))
                        {
                            var countryLookup = await GetCountryCode(country);
                            result.Country = countryLookup?.Name;

                            if (!string.IsNullOrEmpty(province))
                            {
                                result.Province = (await GetProvinceCode(province, countryLookup.Id)).Code;
                            }
                        }
                        if (!string.IsNullOrEmpty(postalCode))
                            result.PostalCode = postalCode;
                    }
                }
                else
                {
                    result.EmailAddress = emailAddress;
                    result.EFTAdvice = "E";
                }

                result.PayAloneFlag = "Y";
            }
        }
        else //GEN CHQ
        {
            if (isBlockSupplier)
            {
                List<string> nameLines = new List<string>();
                if (!string.IsNullOrEmpty(firstName))
                    nameLines.Add(firstName);
                if (!string.IsNullOrEmpty(lastName))
                    nameLines.Add(lastName);
                if (nameLines.Count > 0)
                {
                    result.NameLine1 = string.Join(" ", nameLines);
                    if (result.NameLine1.Length > 40)
                        throw new Exception(string.Format("'{0}' name exceeded 40 character limit..", result.NameLine1));
                }
                if (!string.IsNullOrEmpty(addressLine1))
                    result.AddressLine1 = addressLine1;
                if (!string.IsNullOrEmpty(addressLine2))
                    result.AddressLine2 = addressLine2;
                if (!string.IsNullOrEmpty(addressLine3))
                    result.AddressLine3 = addressLine3;
                if (!string.IsNullOrEmpty(city))
                    result.City = city;
                if (!string.IsNullOrEmpty(country))
                {
                    var countryLookup = await GetCountryCode(country);
                    result.Country = countryLookup?.Name;

                    if (!string.IsNullOrEmpty(province))
                    {
                        result.Province = (await GetProvinceCode(province, countryLookup.Id)).Code;
                    }
                }
                if (!string.IsNullOrEmpty(postalCode))
                    result.PostalCode = postalCode;

                result.PayAloneFlag = "Y";
            }
        }

        if (paymentEntity.SpecialHandling == SpecialHandling.Dback)
        {
            result.PayGroup = "GEN DAY";
            result.SpecialHandling = true;
            result.PayAloneFlag = "Y";
        }

        if (result.GLDate.HasValue && result.GLDate.Value.ToLocalTime() < DateTime.Today)
        {
            result.GLDate = DateTime.Now;
        }

        return result;
    }

    private async Task<string> GenerateDefaultDistributionAccount(Guid programId) 
    {
        var program = await mediator.Send(new FindProgramQuery { Id = programId });
        if (program.ProgramType == null)
            throw new Exception("Program Type lookup is missing.");

        var programTypeQuery = new FindProgramTypeQuery();
        programTypeQuery.Id = program.ProgramType.Id;
        var programType = await mediator.Send(programTypeQuery);
        ArgumentNullException.ThrowIfNull(programType.ClientCode);
        ArgumentNullException.ThrowIfNull(programType.ResponsibilityCentre);
        ArgumentNullException.ThrowIfNull(programType.ServiceLine);
        ArgumentNullException.ThrowIfNull(programType.Stob);
        ArgumentNullException.ThrowIfNull(programType.ProjectCode);

        return string.Format("{0}.{1}.{2}.{3}.{4}.000000.0000", programType.ClientCode, programType.ResponsibilityCentre, programType.ServiceLine, programType.Stob, programType.ProjectCode);
    }

    private async Task<Country> GetCountryCode(string name)
    {
        var findCountryQuery = new SingleCountryQuery();
        findCountryQuery.Name = name;
        findCountryQuery.StateCode = StateCode.Active;
        findCountryQuery.NotNullCode = true;

        Country result = null;
        try
        {
            await mediator.Send(findCountryQuery);
        }
        catch (Exception ex)
        {
            throw new Exception(string.Format("Multiple countries found with name '{0}'.", name));
        }

        if (result == null)
            throw new Exception(string.Format("Country with name '{0}' not found.", name));

        return result;
    }

    private async Task<Province> GetProvinceCode(string name, Guid countryId)
    {
        var findProvinceQuery = new FindProvinceQuery();
        findProvinceQuery.Name = name;
        findProvinceQuery.CountryId = countryId;
        findProvinceQuery.StateCode = StateCode.Active;
        findProvinceQuery.NotNullCode = true;

        Province result = null;
        try
        {
            result = await mediator.Send(findProvinceQuery);
        }
        catch (Exception ex)
        {
            throw new Exception(string.Format("Multiple provinces found with name '{0}'.", name));
        }

        if (result == null)
            throw new Exception(string.Format("Province with name '{0}' and country with id '{1}' not found.", name, countryId));

        return result;
    }
}
