Feature: StatusSearch
	In order to *something*
	As a *user type?*
	I want to verify a Location's Status

@StatusTest
Scenario: Active or Not Active Status
	Given The building number <BLDG_NUM> exists
	When TA is <TA>
	And BLDG_NUM is <BLDG_NUM>
	And Room Number is <ROOM>
	Then the Status should be <STATUS>

	Examples:
		| TA | BLDG_NUM | ROOM   | STATUS     |
		| 3  | 215      | 1UTIL5 | NOT ACTIVE |
		| 3  | 1353     |        | ACTIVE     |
		| 5  | 1302     | NULL   | ACTIVE     |
		| 5  | 2240     | 104    | NOT ACTIVE |
		| 6  | 122      | NULL   | NOT ACTIVE |
		| 0  | 1249     | 101    | NOT ACTIVE |
		| 0  | 1325     | NULL   | ACTIVE     |