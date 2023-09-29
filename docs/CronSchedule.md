# PrefectClient.Model.CronSchedule
Cron schedule\\n\\nNOTE: If the timezone is a DST-observing one, then the schedule will adjust\\nitself appropriately. Cron's rules for DST are based on schedule times, not\\nintervals. This means that an hourly cron schedule will fire on every new\\nschedule hour, not every elapsed hour; for example, when clocks are set back\\nthis will result in a two-hour pause as the schedule will fire *the first\\ntime* 1am is reached and *the first time* 2am is reached, 120 minutes later.\\nLonger schedules, such as one that fires at 9am every morning, will\\nautomatically adjust for DST.\\n\\nArgs:\\n    cron (str): a valid cron string\\n    timezone (str): a valid timezone string in IANA tzdata format (for example,\\n        America/New_York).\\n    day_or (bool, optional): Control how croniter handles `day` and `day_of_week`\\n        entries. Defaults to True, matching cron which connects those values using\\n        OR. If the switch is set to False, the values are connected using AND. This\\n        behaves like fcron and enables you to e.g. define a job that executes each\\n        2nd friday of a month by setting the days of month and the weekday.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cron** | **string** |  | 
**Timezone** | **string** |  | [optional] 
**DayOr** | **bool** | Control croniter behavior for handling day and day_of_week entries. | [optional] [default to true]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

