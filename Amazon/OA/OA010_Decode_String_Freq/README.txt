﻿Amazon Web Services (AWS) is working on a new security feature to help encode text. Consider a string that consists of lowercase English alphabetic letters (i.e., [a-z]) only. The following rules are used to encode all of its characters into string s:

a is encoded as 1, b is encoded as 2, c is encoded as 3, ..., and i is encoded as 9.
j is encoded as 10#, k is encoded as 11#, l is encoded as 12#, ..., and z is encoded as 26#.
If there are two or more consecutive occurrences of any character, then the character count is written within parentheses (i.e., (c), where c is an integer denoting the count of consecutive occurrences being encoded) immediately following the encoded character. For example, consider the following string encodings:
String "abzx" encoded as s = "1226#24#".
String "aabccc" is encoded as s = "1(2)23(3)".
String "bajj" is encoded as s = "2110#(2)".
String "wwxyzwww" is encoded as s = "23#(2)24#25#26#23#(3)".
Given an encoded string s, determine the character counts for each letter of the original, decoded string. Return an integer array of length 26 where index 0 contains the number of 'a' characters, index 1 contains the number of 'b' characters and so on.