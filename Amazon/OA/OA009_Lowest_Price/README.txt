﻿An Amazon seller is celebrating ten years in business! They are having a sale to honor their privileged members, those who have purchased from them in the past five years. These members receive the best discounts indicated by any discount tags attached to the product. Determine the minimum cost to purchase all products listed. As each potential price is calculated, round it to the nearest integer before adding it to the total. Return the cost to purchase all items as an integer.
There are three types of discount tags:
Type O: discounted price, the item is sold for a given price.
Type 1: percentage discount, the customer is given a fixed percentage discount from the retail price.
Type 2: fixed discount, the customer is given a fixed amount off from the retail price.

Example
products = [['10', 'd0', 'd1'], ['15', 'EMPTY', 'EMPTYI', ['20', 'd1',
'EMPTY'I]
discounts = [I'dO','1',27'], ['d1' '21', '5']]

The products array elements are in the form ['price', 'tag 1', 'tag 2', ..., 'tag m-1']. There may be zero or more discount codes associated with a product. Discount tags in the products array may be 'EMPTY' which is the same as a null value. The discounts array elements are in the form ['tag', type', amount].

If a privileged member buys product 1 listed at a price of 10 with two discounts available:
-> Under discount do of type 1, the discounted price is 10 - 10 * 0.27 = 7.30, round to 7.
-> Under discount d1 of type 2, the discounted price is 10 - 5 = 5.
-> The price to purchase the product 1 is the lowest of the two, or 5 in this case
The second product is priced at 15 because there are no discounts available
The third product is priced at 20. Using discount tag d1 of type 2, the discounted price is 20 - 5 = 15
The total price to purchase the three items is 5 + 15 + 15 = 35.