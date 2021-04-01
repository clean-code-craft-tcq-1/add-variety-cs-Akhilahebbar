# Check and Alert based on types

This exercise is based on the [BMS monitoring] domain.

Expand the checks and alerts to take care of a variety of types.

## Open for Extensions

How can you minimize the amount of work done to add a new type?
Can you add without modifying existing code?

## Implementation Details

Used strategical pattern to minimize the comlexity and impove extensibility.

Created interface for Coolingtype to extend  the properties for checks.
created 3 classes which inherit the properties and functions of Cooling Type .
As and when new cooling type added ,using reflection it will create instance and do the checks for battery.

similarly Created interface for Alert
created 2 classes which inherit the properties and functions of Alert.One is for controller alert and other one for Mail.
Depending on the type of instance created alert will trigger after temperature check.

Test cases created for all the functions implemented in TypewiseAlert.


