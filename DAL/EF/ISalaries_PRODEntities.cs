using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace DAL.EF
{
    public interface ISalaries_PRODEntities
    {
        DbSet<AGE> AGES { get; set; }
        DbSet<ARTICLE> ARTICLES { get; set; }
        DbSet<CAREERGROUP> CAREERGROUPS { get; set; }
        DbSet<CAREER> CAREERS { get; set; }
        DbSet<CITy> CITIES { get; set; }
        DbSet<COMMENT> COMMENTS { get; set; }
        DbSet<COUNTRy> COUNTRIES { get; set; }
        DbSet<CURRENCy> CURRENCIES { get; set; }
        DbSet<CURRENCIESUSD> CURRENCIESUSDs { get; set; }
        DbSet<EXPERIENCE> EXPERIENCES { get; set; }
        DbSet<FEEDBACK> FEEDBACKS { get; set; }
        DbSet<GENDER> GENDERs { get; set; }
        DbSet<INTERNALLINK> INTERNALLINKS { get; set; }
        DbSet<KINDOFWORK> KINDOFWORKs { get; set; }
        DbSet<PAYMENT> PAYMENTS { get; set; }
        DbSet<PROCEED> PROCEEDS { get; set; }
        DbSet<RANGEGROUP> RANGEGROUPS { get; set; }
        DbSet<RANx> RANGES { get; set; }
        DbSet<RESTRICTEDBROWSER> RESTRICTEDBROWSERS { get; set; }
        DbSet<RESTRICTED> RESTRICTEDs { get; set; }
        DbSet<SALARy> SALARIES { get; set; }
        DbSet<SALARYANSWER> SALARYANSWERS { get; set; }
        DbSet<SALARYLEVEL> SALARYLEVELS { get; set; }
        DbSet<SALARYQUESTION> SALARYQUESTIONS { get; set; }
        DbSet<STATE> STATES { get; set; }
        DbSet<URL> URLS { get; set; }
        DbSet<viewSalary> viewSalaries { get; set; }
        DbSet<viewSalaries_ALL> viewSalaries_ALL { get; set; }
        DbSet<VISITOR> VISITORS { get; set; }

        int Add_Update_PageContent(string contentType, string contentID, string contentText);
        int DeleteComment(int? commentID);
        ObjectResult<GetAge_ByID_Result> GetAge_ByID(string ageID);
        ObjectResult<string> GetArticleID_ByLocationID(string locationID, string articleType);
        ObjectResult<GetCareerGroupsForSelect_ALL_Result> GetCareerGroupsForSelect_ALL();
        ObjectResult<GetCareerGroups_ALL_Result> GetCareerGroups_ALL();
        ObjectResult<GetCareerGroup_ByID_Result> GetCareerGroup_ByID(string careerGroupID);
        ObjectResult<GetCareers_ALL_Result> GetCareers_ALL();
        ObjectResult<GetCareers_ForCareerGroupID_Result> GetCareers_ForCareerGroupID(string careerGroupID);
        ObjectResult<GetCareer_ByID_Result> GetCareer_ByID(string careerID);
        ObjectResult<GetCities_ALL_Result> GetCities_ALL();
        ObjectResult<GetCities_ByCountryID_Result> GetCities_ByCountryID(string countryID);
        ObjectResult<GetCities_ByStateID_Result> GetCities_ByStateID(string stateID);
        ObjectResult<GetCity_ByID_Result> GetCity_ByID(string cityID);
        ObjectResult<GetComments_ByUrlID_Result> GetComments_ByUrlID(string commentForURL);
        ObjectResult<GetComment_ByID_Result> GetComment_ByID(int? commentID);
        ObjectResult<GetCountnriesForSelect_ALL_Result> GetCountnriesForSelect_ALL();
        ObjectResult<GetCountnries_ALL_Result> GetCountnries_ALL();
        ObjectResult<GetCountriesForSelect_ALL_Result> GetCountriesForSelect_ALL();
        ObjectResult<GetCountries_ALL_Result> GetCountries_ALL();
        ObjectResult<GetCountry_ByID_Result> GetCountry_ByID(string countryID);
        ObjectResult<GetCurrencies_ALL_Result> GetCurrencies_ALL();
        ObjectResult<GetCurrency_ByID_Result> GetCurrency_ByID(string currencyID);
        ObjectResult<GetEducation_ALL_Result> GetEducation_ALL();
        ObjectResult<GetEducation_ByID_Result> GetEducation_ByID(string educationID);
        ObjectResult<GetExperience_ALL_Result> GetExperience_ALL();
        ObjectResult<GetExperience_ByID_Result> GetExperience_ByID(string experienceID);
        ObjectResult<GetGender_ByID_Result> GetGender_ByID(string genderID);
        int GetGroupedSalaries(string groupBy, string countryID, string stateID, string cityID, string isEUSurvey, string careerGroupID, string careerID, string levelID, string genderID, string eduID, string experienceID, string ageID, string year, string kindOfWork, string startWith);
        ObjectResult<GetInternalLinks_ByFromID_Result> GetInternalLinks_ByFromID(string fromID, string fromView);
        ObjectResult<GetKindOfWork_ByID_Result> GetKindOfWork_ByID(string kindofworkID);
        ObjectResult<GetPageContent_ByID_Result> GetPageContent_ByID(string contentID);
        ObjectResult<GetPageContent_ByParameters_Result> GetPageContent_ByParameters(string locationID, string articleType, string isEUSurvey);
        ObjectResult<GetPageContent_ForID_Result> GetPageContent_ForID(string pForID, string pAticleType);
        ObjectResult<GetProceed_ByID_Result> GetProceed_ByID(int? proceedID);
        ObjectResult<GetRange_ByUrlID_Result> GetRange_ByUrlID(string countryID, string urlID);
        ObjectResult<GetSalariesByCareerAndLocationForCheck_Paged_Result> GetSalariesByCareerAndLocationForCheck_Paged(string countryID, string stateID, string cityID, string isEUSurvey, string careerGroupID, string careerID, string kindOfWork, string levelID, string genderID, string eduID, string experienceID, string ageID, string year, int? startRowIndex, int? maxNumRows, string startWith);
        ObjectResult<int?> GetSalariesByCareerAndLocation_Count(string countryID, string stateID, string cityID, string isEUSurvey, string careerGroupID, string careerID, string levelID, string genderID, string eduID, string experienceID, string ageID, string year, string kindOfWork, string startWith);
        ObjectResult<int?> GetSalariesByCareerAndLocation_Count_AllThisMonth();
        ObjectResult<int?> GetSalariesByCareerAndLocation_Count_AllThisWeek();
        ObjectResult<GetSalariesByCareerAndLocation_ForDetails_Result> GetSalariesByCareerAndLocation_ForDetails(string countryID, string stateID, string cityID, string isEUSurvey, string careerGroupID, string careerID, string kindOfWork, string levelID, string genderID, string eduID, string experienceID, string ageID, string year, int? startRowIndex, int? maxNumRows, string startWith);
        ObjectResult<GetSalariesByCareerAndLocation_Paged_Result> GetSalariesByCareerAndLocation_Paged(string countryID, string stateID, string cityID, string isEUSurvey, string careerGroupID, string careerID, string kindOfWork, string levelID, string genderID, string eduID, string experienceID, string ageID, string year, int? startRowIndex, int? maxNumRows, string startWith);
        ObjectResult<GetSalariesGroupedByCountriesAll_Result> GetSalariesGroupedByCountriesAll();
        ObjectResult<GetSalaryDetailsByID_Result> GetSalaryDetailsByID(int? pID);
        ObjectResult<GetSalaryURL_BySourceID_Result> GetSalaryURL_BySourceID(string pSourceID, string pKindOfView);
        ObjectResult<GetSalaryURL_ByURLID_Result> GetSalaryURL_ByURLID(string uRLID);
        ObjectResult<GetStatesForCountryID_ALL_Result> GetStatesForCountryID_ALL(string countryID);
        ObjectResult<GetStates_ALL_Result> GetStates_ALL();
        ObjectResult<GetStates_ByCityID_Result> GetStates_ByCityID(string cityID);
        ObjectResult<GetState_ByID_Result> GetState_ByID(string stateID);
        ObjectResult<GetVisitor_ByVisitorIP_Result> GetVisitor_ByVisitorIP(string visitorIP);
        ObjectResult<Get_Payment_ForEmail_Result> Get_Payment_ForEmail(string emailID);
        int InsertArticle(string articleType, string articleCountryStateCity, string articleContent, string country);
        int InsertComment(string commentForURL, string commentText, DateTime? commentDate, string authorName, string authorIP);
        int Insert_Payment(string emailID, string password, DateTime? latestPayment, string kindOfPayment, string visitorIP);
        ObjectResult<decimal?> Insert_Proceed(int? proceedID, string visitorIP, string proceedFromPage, string salaryAddedAttempts, string proceedErrors, string salaryAdded);
        int Insert_Salary(string country, string city, string careerGroup, string career, string careerDescription, int? grossSalary, int? netSalary, string experiences, string education, string permanentContract, string gender, int? age, string visitorIP);
        int Insert_Visitor(string visitorIP);
        ObjectResult<IsCityInTheCountry_Result> IsCityInTheCountry(string cityID, string countryID);
        ObjectResult<string> IsSalaryForIPAdded_InLast24Months(string pID);
        int UpdateArticle(string articleType, string articleCountryStateCity, string articleContent);
        int UpdateCareer(string iD, string uRL, string imageURL);
        int UpdateCareerGroup(string iD, string uRL, string imageURL);
        int UpdateCity(string iD, string uRL, string imageURL);
        int UpdateComment(int? commentID, string commentText);
        int UpdateCountry(string iD, string uRL, string imageURL);
        int UpdateCurrencyEUR_ByID(string currencyID, double? currencyRatioToEUR);
        int UpdateCurrencyUSD_ByID(string currencyID, double? currencyRatioToUSD);
        int UpdateProceed_ByID(int? proceedID, string visitorIP, string proceedFromPage, string salaryAddedAttempts, string proceedErrors, string salaryAdded);
        int UpdateState(string iD, string uRL, string imageURL);
        int UpdateVisitorAttempt_ByVisitorIP(string visitorIP, int? currentAttempts);
    }
}