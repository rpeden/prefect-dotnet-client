# PrefectClient.Model.RRuleSchedule
RRule schedule, based on the iCalendar standard\\n([RFC 5545](https://datatracker.ietf.org/doc/html/rfc5545)) as\\nimplemented in `dateutils.rrule`.\\n\\nRRules are appropriate for any kind of calendar-date manipulation, including\\nirregular intervals, repetition, exclusions, week day or day-of-month\\nadjustments, and more.\\n\\nNote that as a calendar-oriented standard, `RRuleSchedules` are sensitive to\\nto the initial timezone provided. A 9am daily schedule with a daylight saving\\ntime-aware start date will maintain a local 9am time through DST boundaries;\\na 9am daily schedule with a UTC start date will maintain a 9am UTC time.\\n\\nArgs:\\n    rrule (str): a valid RRule string\\n    timezone (str, optional): a valid timezone string

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Rrule** | **string** |  | 
**Timezone** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

