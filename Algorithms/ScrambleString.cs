// Source : https://leetcode.com/problems/scramble-string/ 
// Author : codeyu 
// Date : Friday, February 17, 2017 9:10:35 PM 

/**********************************************************************************
*
* 
* Given a string s1, we may represent it as a binary tree by partitioning it to two non-empty substrings recursively.
* 
* 
* Below is one possible representation of s1 = "great":
* 
* 
*     great
*    /    \
*   gr    eat
*  / \    /  \
* g   r  e   at
*            / \
*           a   t
* 
* 
* To scramble the string, we may choose any non-leaf node and swap its two children.
* 
* 
* For example, if we choose the node "gr" and swap its two children, it produces a scrambled string "rgeat".
* 
* 
*     rgeat
*    /    \
*   rg    eat
*  / \    /  \
* r   g  e   at
*            / \
*           a   t
* 
* 
* We say that "rgeat" is a scrambled string of "great".
* 
* 
* Similarly, if we continue to swap the children of nodes "eat" and "at", it produces a scrambled string "rgtae".
* 
* 
*     rgtae
*    /    \
*   rg    tae
*  / \    /  \
* r   g  ta  e
*        / \
*       t   a
* 
* 
* We say that "rgtae" is a scrambled string of "great".
* 
* 
* Given two strings s1 and s2 of the same length, determine if s2 is a scrambled string of s1.
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
public class Solution087 {
    public static bool IsScramble(string s1, string s2) {throw new NotImplementedException("TODO");
        
    }
}}

