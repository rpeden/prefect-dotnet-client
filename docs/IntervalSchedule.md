# PrefectClient.Model.IntervalSchedule
A schedule formed by adding `interval` increments to an `anchor_date`. If no\\n`anchor_date` is supplied, the current UTC time is used.  If a\\ntimezone-naive datetime is provided for `anchor_date`, it is assumed to be\\nin the schedule's timezone (or UTC). Even if supplied with an IANA timezone,\\nanchor dates are always stored as UTC offsets, so a `timezone` can be\\nprovided to determine localization behaviors like DST boundary handling. If\\nnone is provided it will be inferred from the anchor date.\\n\\nNOTE: If the `IntervalSchedule` `anchor_date` or `timezone` is provided in a\\nDST-observing timezone, then the schedule will adjust itself appropriately.\\nIntervals greater than 24 hours will follow DST conventions, while intervals\\nof less than 24 hours will follow UTC intervals. For example, an hourly\\nschedule will fire every UTC hour, even across DST boundaries. When clocks\\nare set back, this will result in two runs that *appear* to both be\\nscheduled for 1am local time, even though they are an hour apart in UTC\\ntime. For longer intervals, like a daily schedule, the interval schedule\\nwill adjust for DST boundaries so that the clock-hour remains constant. This\\nmeans that a daily schedule that always fires at 9am will observe DST and\\ncontinue to fire at 9am in the local time zone.\\n\\nArgs:\\n    interval (datetime.timedelta): an interval to schedule on\\n    anchor_date (DateTimeTZ, optional): an anchor date to schedule increments against;\\n        if not provided, the current timestamp will be used\\n    timezone (str, optional): a valid timezone string

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Interval** | **decimal** |  | 
**AnchorDate** | **DateTime** |  | [optional] 
**Timezone** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

