using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornbill.ESPAPI.RequestObjects
{
    class GetRequest
    {
    }
}
//requestNumberEquals The specified Request number is equal to this value
//requestNumberNotEquals  The specified Request number is not equal to this value
//requestNumberGreater   The specifed Request number is greater than this value
//requestNumberLess   The specifed Request number is less than this value
//requestNumberRegex  The specifed Request number matches this regular expression
//requestNumberNotRegex The specifed Request number does not match this reqular expression
//summaryEquals The summary of a request matches this value
//summaryNotEquals The summary of a request does not match this value
//summaryGreater    The summary of a request is greater than this value
//summaryLess    The summary of a request is less than this value
//summaryRegex The summary of a request matches this regular expression
//summaryNotRegex The summary of a request does not match this regular expression
//descriptionEquals The descirption of a request matches this value
//descriptionNotEquals The description of a request does not match this value
//descriptionGreater The description of a request is greater than this value
//descriptionLess    The description of a request is less than this value
//descriptionRegex    The description of a request matches this regular expression
//descriptionNotRegex The description of a request does not match this regular expression
//customerEquals The Customer matches this value
//customerNotEquals The Customer does not match this value
//customerTypeEquals The Customer Type matches this value
//customerTypeNotEquals The Customer Type does not match this value
//organisationEquals The Organisation matches this value
//organisationNotEquals The Organisation does not match this value
//createdByEquals The request creator matches this value
//createdByNotEquals The request creator does not match this value
//reopenedEquals The reopened count matches this value
//reopenedNotEquals The reopened count does not match this value
//reopenedGreater    The reopened count is greater than this value
//reopenedLess    The reopened count is less than this value
//priorityEquals The priority matches this value
//priorityNotEquals The priority does not match this value
//priorityGreater     The priority is greater than this value
//priorityLess       The priority is less than this value
//typeEquals The request type matches this value
//typeNotEquals The request type does not match this value
//statusEquals The status matches this value
//statusNotEquals The status does not match this value
//loggedAfter xs:string optional    The request was logged after this date
//loggedBefore    xs:string optional    The request was logged before this date
//loggedLastXDays xs:integer optional    The request was logged in the last X days
//loggedBeforeXDays xs:integer optional    The request was more than X days ago
//resolvedAfter xs:string optional    The request was resolved after this date
//resolvedBefore  xs:string optional    The request was resolved before this date
//resolvedLastXDays   xs:integer optional    The request was resolved in the last X days
//resolvedByEquals The request was resolved by this person
//resolvedByNotEquals xs:string optional The request was not resolved by this person
//resolvedByTeamEquals    xs:string optional  The request was resolved by this team
//resolvedByTeamNotEquals xs:string optional The request was not resolved by this team
//closedAfter xs:string optional    The request was closed after this date
//closedBefore    xs:string optional    The request was closed before this date
//closedLastXDays xs:integer optional    The request was closed in the last X days
//closedByEquals xs:string optional The request was closed by this person
//closedByNotEquals   The request was not closed by this person
//closedByTeamEquals   The request was closed by this team
//closedByTeamNotEquals   xs:string optional
//minOccurs= 0
//maxOccurs= unbounded The request was not closed by this team
//timeOnHoldEquals    xs:integer optional
//minOccurs= 0
//maxOccurs= unbounded The total time spent on hold equals this value
//timeOnHoldNotEquals The total time spent on hold does not equal this value
//timeOnHoldGreater  The total time spent on hold is greater than this value
//timeOnHoldLess  The total time spent on hold is less than this value
//withinResponseTimeEquals   The request was completed within the response time
//withinFixTimeEquals The request was completed within the fix time
//responseTimeEquals The response time for the request matches this value
//responseTimeNotEquals The response time for the request does not match this value
//categoryEquals The category for the request matches this value
//categoryNotEquals The category for the reuqest does not match this value
//closureEquals The closure category for the request matches this value
//closureNotEquals The closure category for the request does not match this value
//ratingEquals The customer rating of the request matches this value
//ratingNotEquals The customer rating of the request does not match this value
//ratingGreater    The customer rating of the request is greater than this value
//ratingLess   The customer rating of the request is less than this value
//impactEquals The impact matches this value
//impactNotEquals The impact does not match this value
//impactGreater The impact is greater than this value
//impactLess The impact is less than this value
//urgencyEquals The urgency matches this value
//urgencyNotEquals The urgency does not match this value
//urgencyGreater  The urgency is greater than this value
//urgencyLess The urgency is less than this value
//lastModifiedAfter The last modified date is after this value
//lastModifiedBefore  The last modified date is before value
//lastModifiedLastXDays  The last modified date is in the last X days
//lastModifiedBeforeXDays The last modified date before the last X days
//resolutionEquals  The resolution matches this value
//resolutionNotEquals  The resolution does not match this value
//resolutionGreater The resolution is greater than this value
//resolutionLess The resolution is less than this value
//resolutionRegex The resolution matches this regular expression
//resolutioNotRegex The resolution does not match this regular expression
//externalReferenceEquals  The External reference matches this value
//externalReferenceNotEquals The Exernal reference does not match this value
//externalReferenceGreater The External reference is greater than this value
//externalReferenceLess  The External reference is less than this value
//externalReferenceRegex  The external reference matches this regular expression
//externalReferenceNotRegex The external reference does not match this regular expression
//slaNameEquals xs:string  The External reference matches this value
//slaNameNotEquals The Exernal reference does not match this value
//slaNameGreater   The External reference is greater than this value
//slaNameLess The External reference is less than this value
//slaNameRegex The external reference matches this regular expression
//slaNameNotRegex The external reference does not match this regular expression
//slNameEquals  The External reference matches this value
//slNameNotEquals he Exernal reference does not match this value
//slNameGreater The External reference is greater than this value
//slNameLess  The External reference is less than this value
//slNameRegex   The external reference matches this regular expression
//slNameNotRegex  The external reference does not match this regular expression
//reopenDateAfter The request was reopened after this date
//reopenDateBefore  The request was reopened before this date
//reopenDateLastXDays  The request was reopened in the last X days
//reopenedByEquals  The request was reopened by this person
//reopenedByNotEquals  The request was not opened by this person
//reopenedByTeamEquals  The request was reopened by this team
//reopenedByTeamNotEquals The request was not reopened by this team
//assetEquals  The asset equals
//assetNotEquals The asset does not equals
//serviceEquals The service equals
//serviceNotEquals The service does not equal
//companyEquals The company matches this value
//companyNotEquals The company does not match this value
//siteEquals The site matches this value
//siteNotEquals The site does not match this value
//sourceEquals The source matches this value
//sourceNotEquals The source does not match this value
//reopenCountEquals  The reopen count matches this value
//reopenCountNotEquals The reopen count does not match this value
//respondByAfter  The request needed to be responded to after this date
//respondByBefore The request needed to be responded to before this date
//respondByBeforeXDays The request needed to be responded to before X amount of days ago
//respondByLastXDays The request needed to be responded to during the last x days
//resolveByAfter The request should be resolved after this date
//resolveByBefore  The request should be resolved before this date
//resolveByBeforeXDays The request should be resolved before X amount of days ago
//resolveByLastXDays The request should be resolved during the last x days
//customAEquals  The custom field A matches this value
//customANotEquals The custom field A does not match this value
//customAGreater The custom field A is greater than this value
//customALess The custom field A is less than this value
//customARegex The custom field A matches this regular expression
//customANotRegex The custom field A does not match this regular expression
//customBEquals  The custom field B matches this value
//customBNotEquals  The custom field B does not match this value
//customBGreater The custom field B is greater than this value
//customBLess The custom field B is less than this value
//customBRegex  The custom field B matches this regular expression
//customBNotRegex The custom field B does not match this regular expression
//customCEquals  The custom field C matches this value
//customCNotEquals  The custom field C does not match this value
//customCGreater  The custom field C is greater than this value
//customCLess The custom field C is less than this value
//customCRegex The custom field C does not match this regular expression
//customCNotRegex  The custom field C does not match this regular expression
//customDEquals The custom field D matches this value
//customDNotEquals The custom field D does not match this value
//customDGreater   The custom field D is greater than this value
//customDLess The custom field D is less than this value
//customDRegex The custom field D matches this regular expression
//customDNotRegex The custom field D does not match this regular expression
//customEEquals The custom field E matches this value
//customENotEquals The custom field E does not match this value
//customEGreater The custom field E is greater than this value
//customELess  The custom field E is less than this value
//customERegex The custom field E matches this regular expression
//customENotRegex The custom field E does not match this regular expression
//customFEquals  The custom field F matches this value
//customFNotEquals The custom field F does not match this value
//customFGreater The custom field F is greater than this value
//customFLess The custom field F is less than this value
//customFRegex  The custom field F matches this regular expression
//customFNotRegex The custom field F does not match this regular expression
//customGEquals The custom field G matches this value
//customGNotEquals  The custom field G does not match this value
//customGGreater The custom field G is greater than this value
//customGLess  The custom field G is less than this value
//customGRegex The custom field G matches this regular expression
//customGNotRegex The custom field G does not match this regular expression
//customHEquals  The custom field H matches this value
//customHNotEquals The custom field H does not match this value
//customHGreater The custom field H is greater than this value
//customHLess The custom field H is less than this value
//customHRegex    The custom field H matches this regular expression
//customHNotRegex The custom field H does not match this regular expression
//customIEquals  The custom field I matches this value
//customINotEquals The custom field I does not match this value
//customIGreater  The custom field I is greater than this value
//customILess  The custom field I is less than this value
//customIRegex  The custom field I matches this regular expression
//customINotRegex The custom field I does not match this regular expression
//customJEquals  The custom field J matches this value
//customJNotEquals The custom field J does not match this value
//customJGreater The custom field J is greater than this value
//customJLess The custom field J is less than this value
//customJRegex    The custom field J matches this regular expression
//customJNotRegex The custom field J does not match this regular expression
//customKEquals The custom field K matches this value
//customKNotEquals The custom field K does not match this value
//customKGreater  xs:string optional    The custom field K is greater than this value
//customKLess xs:string optional    The custom field K is less than this value
//customKRegex    xs:string optional    The custom field K matches this regular expression
//customKNotRegex xs:string optional    The custom field K does not match this regular expression
//customLEquals The custom field L matches this value
//customLNotEquals The custom field L does not match this value
//customLGreater  xs:string optional    The custom field L is greater than this value
//customLLess xs:string optional    The custom field L is less than this value
//customLRegex    xs:string optional    The custom field L matches this regular expression
//customLNotRegex xs:string optional    The custom field L does not match this regular expression
//customMEquals The custom field M matches this value
//customMNotEquals The custom field M does not match this value
//customMGreater  xs:string optional    The custom field M is greater than this value
//customMLess xs:string optional    The custom field M is less than this value
//customMRegex    xs:string optional    The custom field M matches this regular expression
//customMNotRegex xs:string optional    The custom field M does not match this regular expression
//customNEquals The custom field N matches this value
//customNNotEquals The custom field N does not match this value
//customNGreater  The custom field N is greater than this value
//customNLess  The custom field N is less than this value
//customNRegex The custom field N matches this regular expression
//customNNotRegex The custom field N does not match this regular expression
//customOEquals The custom field O matches this value
//customONotEquals The custom field O does not match this value
//customOGreater The custom field O is greater than this value
//customOLess The custom field O is less than this value
//customORegex   The custom field O matches this regular expression
//customONotRegex The custom field O does not match this regular expression
//custom21After The custom 21 field value needs to be after this date
//custom21Before  The custom 21 field value needs to be before this date
//custom21BeforeXDays The custom 21 field value needs to be before X amount of days ago
//custom21LastXDays  The custom 21 field value needs to be during the last x days
//custom21Today The custom 21 field value should be today.The options are "true" or "false".
//custom21Yesterday The custom 21 field value should be yesterday.The options are "true" or "false".
//custom21LastWeek The custom 21 field value should be in the last week.The options are "true" or "false".
//custom21LastMonth xs:string optional    The custom 21 field value should be in the last month.The options are "true" or "false".
//custom21ThisMonth xs:string optional    The custom 21 field value should be in the current month.The options are "true" or "false".
//custom21PreviousMonth xs:string optional    The custom 21 field value should be in the last month.The options are "true" or "false".
//custom22After xs:string optional    The custom 22 field value needs to be after this date
//custom22Before  xs:string optional    The custom 22 field value needs to be before this date
//custom22BeforeXDays xs:string optional    The custom 22 field value needs to be before X amount of days ago
//custom22LastXDays   xs:string optional    The custom 22 field value needs to be during the last x days
//custom22Today xs:string optional    The custom 22 field value should be today.The options are "true" or "false".
//custom22Yesterday xs:string optional    The custom 22 field value should be yesterday.The options are "true" or "false".
//custom22LastWeek xs:string optional    The custom 22 field value should be in the last week.The options are "true" or "false".
//custom22LastMonth xs:string optional    The custom 22 field value should be in the last month.The options are "true" or "false".
//custom22ThisMonth xs:string optional    The custom 22 field value should be in the current month.The options are "true" or "false".
//custom22PreviousMonth xs:string optional    The custom 22 field value should be in the last month.The options are "true" or "false".
//custom23After xs:string optional    The custom 23 field value needs to be after this date
//custom23Before  xs:string optional    The custom 23 field value needs to be before this date
//custom23BeforeXDays xs:string optional    The custom 23 field value needs to be before X amount of days ago
//custom23LastXDays   xs:string optional    The custom 23 field value needs to be during the last x days
//custom23Today xs:string optional    The custom 23 field value should be today.The options are "true" or "false".
//custom23Yesterday xs:string optional    The custom 23 field value should be yesterday.The options are "true" or "false".
//custom23LastWeek xs:string optional    The custom 23 field value should be in the last week.The options are "true" or "false".
//custom23LastMonth xs:string optional    The custom 23 field value should be in the last month.The options are "true" or "false".
//custom23ThisMonth xs:string optional    The custom 23 field value should be in the current month.The options are "true" or "false".
//custom23PreviousMonth xs:string optional    The custom 23 field value should be in the last month.The options are "true" or "false".
//custom24After xs:string optional    The custom 24 field value needs to be after this date
//custom24Before  xs:string optional    The custom 24 field value needs to be before this date
//custom24BeforeXDays xs:string optional    The custom 24 field value needs to be before X amount of days ago
//custom24LastXDays   xs:string optional    The custom 24 field value needs to be during the last x days
//custom24Today xs:string optional    The custom 24 field value should be today.The options are "true" or "false".
//custom24Yesterday xs:string optional    The custom 24 field value should be yesterday.The options are "true" or "false".
//custom24LastWeek xs:string optional    The custom 24 field value should be in the last week.The options are "true" or "false".
//custom24LastMonth xs:string optional    The custom 24 field value should be in the last month.The options are "true" or "false".
//custom24ThisMonth xs:string optional    The custom 24 field value should be in the current month.The options are "true" or "false".
//custom24PreviousMonth xs:string optional    The custom 24 field value should be in the last month.The options are "true" or "false".
//custom25After xs:string optional    The custom 25 field value needs to be after this date
//custom25Before  xs:string optional    The custom 25 field value needs to be before this date
//custom25BeforeXDays xs:string optional    The custom 25 field value needs to be before X amount of days ago
//custom25LastXDays   xs:string optional    The custom 25 field value needs to be during the last x days
//custom25Today xs:string optional    The custom 25 field value should be today.The options are "true" or "false".
//custom25Yesterday xs:string optional    The custom 25 field value should be yesterday.The options are "true" or "false".
//custom25LastWeek xs:string optional    The custom 25 field value should be in the last week.The options are "true" or "false".
//custom25LastMonth xs:string optional    The custom 25 field value should be in the last month.The options are "true" or "false".
//custom25ThisMonth xs:string optional    The custom 25 field value should be in the current month.The options are "true" or "false".
//custom25PreviousMonth xs:string optional    The custom 25 field value should be in the last month.The options are "true" or "false".
//custom26Equals  The custom field 26 matches this value
//custom26NotEquals The custom field 26 does not match this value
//custom26Greater The custom field 26 is greater than this value
//custom26Less    The custom field 26 is less than this value
//custom26Regex  The custom field 26 matches this regular expression
//custom26NotRegex The custom field 26 does not match this regular expression
//custom27Equals The custom field 27 matches this value
//custom27NotEquals The custom field 27 does not match this value
//custom27Greater The custom field 27 is greater than this value
//custom27Less   The custom field 27 is less than this value
//custom27Regex  The custom field 27 matches this regular expression
//custom27NotRegex The custom field 27 does not match this regular expression
//custom28Equals The custom field 28 matches this value
//custom28NotEquals The custom field 28 does not match this value
//custom28Greater The custom field 28 is greater than this value
//custom28Less    The custom field 28 is less than this value
//custom28Regex   The custom field 28 matches this regular expression
//custom28NotRegex The custom field 28 does not match this regular expression
//custom29Equals The custom field 29 matches this value
//custom29NotEquals The custom field 29 does not match this value
//custom29Greater The custom field 29 is greater than this value
//custom29Less   The custom field 29 is less than this value
//custom29Regex  The custom field 29 matches this regular expression
//custom29NotRegex The custom field 29 does not match this regular expression
//custom30Equals The custom field 30 matches this value
//custom30NotEquals The custom field 30 does not match this value
//custom30Greater The custom field 30 is greater than this value
//custom30Less    The custom field 30 is less than this value
//custom30Regex   The custom field 30 matches this regular expression
//custom30NotRegex The custom field 30 does not match this regular expression
//archiveEquals The archive status matches this value
//ownerEquals The archive status does not match this value
//ownerNotEquals  The owner does not match this value
//teamEquals  The team matches this value
//teamNotEquals The team does not match this value
//memberEquals The member matches this value
//followingEquals The following status matches this value
//boolProblemFixEquals The fixed by problem status matches this value
//textFilter  Filter by text
//teamEmpty   The team is empty
//subStatusEquals The subStatus ID matches this value
//subStatusNotEquals  The subStatus ID does not match this value
//catalogEquals   The catalog ID that matches this value
//catalogNotEquals  The catalog ID that does not match this value
//rowstart    xs:integer required once The row to start fetching data from
//limit xs:integer required once The max number of rows to return
//exportColumns xs:string optional    exportColumns
//chartColumn xs:string optional    Chart Column Parameter
//chartDrilldown  xs:string optional    Chart Drilldown Parameter
//optqueryType    xs:string optional    The X does not match/matches this value
//optgroupBy  xs:string optional    The option to group by
//optwithinResponseTimeEmpty  xs:string optional    The within response time column is empty
//optwithinFixTimeEmpty   xs:string optional    The within fix time column is empty
//optloggedToday  xs:string optional    The request was logged today
//optloggedYesterday  xs:string optional    The request was logged yesterday
//optloggedLastWeek   xs:string optional    The request was logged last week
//optloggedLastMonth xs:string optional    The request was logged last month
//optloggedThisMonth xs:string optional    Requests logged this month
//optloggedPreviousMonth  xs:string optional    Requests logged previous month
//optresolveByToday xs:string optional    The request should be resolved today
//optresolveByYesterday xs:string optional    The request should be resolved yesterday
//optresolveByLastWeek xs:string optional    The request should be resolved in the last week
//optresolveByLastMonth   xs:string optional    The request should be resolved in the last month
//optresolveByThisMonth   xs:string optional    The request should be resolved this month
//optresolveByPreviousMonth   xs:string optional    The request should be resolved in the previous month
//optrespondByToday   xs:string optional    The request should be responded to today
//optrespondByYesterday   xs:string optional    The request should have been responded to yesterday
//optrespondByLastWeek xs:string optional    The request should have been responded to in the last week
//optrespondByLastMonth   xs:string optional    The request should have been responded to in the last month
//optrespondByThisMonth   xs:string optional    The request should have been responded to this month
//optrespondByPreviousMonth   xs:string optional    The request should have been responded to the previous month
//optresolvedToday xs:string optional    The request was resolved today
//optresolvedYesterday    xs:string optional    The request was resolved yesterday
//optresolvedLastWeek xs:string optional    The request was resolved last week
//optresolvedLastMonth xs:string optional    The request was resolved last month
//optresolvedThisMonth xs:string optional    Request resolved this month
//optresolvedPreviousMonth    xs:string optional    Request resolved the previous month
//optclosedToday  xs:string optional    The request was closed today
//optclosedYesterday  xs:string optional    The request was closed yesterday
//optclosedLastWeek   xs:string optional    The request was closed last week
//optclosedLastMonth xs:string optional    The request was closed last month
//optclosedThisMonth xs:string optional    The request was closed this month
//optclosedPreviousMonth  xs:string optional    The request was closed the previous month
//optlastModifiedToday    xs:string optional    The request was last modified today
//optlastModifiedYesterday xs:string optional    The request was last modified yesterday
//optlastModifiedLastWeek xs:string optional    The request was last modified last week
//optlastModifiedLastMonth    xs:string optional    The request was last modified last month
//optlastModifiedThisMonth    The request was last modified this month
//optlastModifiedPreviousMonth    The request was last modified the previous month
//optownerEmpty The owner is empty
//optteamEmpty    The team is empty
//optreopenDateToday  The reopen date is today
//optreopenDateYesterday  The reopen date was yesterday
//optreopenDateLastWeek   The reopen date was last week
//optreopenDateLastMonth The reopen date was last month
//optreopenDateThisMonth The request was reopened this month
//optreopenDatePreviousMonth  The request was reopened the previous month
//optmemberOfRequest  The user is a member of the request
//optfollowingRequest The user is following the request
//optserviceOnly  Only specific Service
//orderByColumn   The column to order by
//orderByDirection    The direction to order by
//visibleColumns  The columns visible to the user