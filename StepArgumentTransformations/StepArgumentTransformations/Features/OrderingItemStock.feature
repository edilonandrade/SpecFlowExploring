Feature: OrderingItemStock
	
Scenario: Ordering an item in stock
  Given we have '3' items in stock.
  When we order '1' item
  Then we should have '2' items in stock left.

Scenario: Ordering the last item in stock
  Given we have '1' items in stock.
  When we order '1' item
  Then we should have '0' items in stock left.

Scenario: Ordering no item in stock
  Given we have 'no' items in stock.
  When we order '1' item
  Then we should have '-1' items in stock left.

Scenario Outline: Ordering items in stock
  Given we have '<ItemsInStock>' items in stock.
  When we order '<OrderedItems>' item
  Then we should have '<ItemsLeft>' items in stock left.
Examples:
| ItemsInStock | OrderedItems | ItemsLeft |
|            3 |            1 |         2 |
|            1 |            1 |         0 |