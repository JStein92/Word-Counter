# Word Counter #
## By Jonathan Stein ##
## _A site that lets users see how many times a word appears in a given sentence_ ##
___
## Specifications



### 1. User inputs a sentence and a word, and the program returns true if the word is contained in the sentence.
- Input: "This is a test", "test"
- Output: True

        Spec #1's input/output is designed to test the most basic form of a "contains" method - exact matches only in capitalization, with spaces between words as expected

### 2. User inputs a sentence, and the program returns how many words are in the sentence.
 - Input: "This is a test"
 - Output: 4

         Spec #2's input/output is designed to be the simpliest version of a word counter - normal spacing between words and no non-alphanumeric symbols

### 3. User inputs a sentence and a word, and the program returns how many times the word is contained in the sentence. 
- Input: "This is a test test", "test"
- Output: 2

         Spec #3's input/output once again using normal spacing/capitalization to find the number of occurances input word in the given sentence

### 4. User inputs a sentence and a word, and the program returns how many times the word is contained in the sentence, ignoring differences in capitalization.

- Input: "This is a programTeST tEst!", "teSt"
- Output: 1

         Spec #4's input/output is designed to account for irregular spacing and capitalization in the input - the inputs will test for each letter ("t, "e" "s", "t") in the given word being an alternative capitalization than in the given sentence. To be clear we do NOT want the word to be found if there is no space, because that could result in false positives, like finding "test" in the sentence "testing"

### _Content_ ###

Index.cshtml:

 - Splash page -where user can enter word and sentence to search

Result.cshtml:

- Displays how many times the user's word is found in the given sentence

Other:
- RepeatCounter.cs
  - The primary model
- HomeController.cs
- Layout.cshtml
- Styles.css
- Scripts.js

### _How to use_ ###

1. Download project from GitHub: https://github.com/JStein92/Word-Counter
2. Run HTML in preferred browser
3. Follow instructions on page
  - Enter a word to search
  - Enter a sentence to search for the word in

#### _Legal Information_ ####
Copyright (c) 2017 Copyright Holder All Rights Reserved.
Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so.

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
