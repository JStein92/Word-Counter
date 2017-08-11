## Specs

___

1. User inputs a sentence and a word, and the program returns true if the word is contained in the sentence.
- Input: "This is a test", "test"
- Output: True

        Spec #1's input/output is designed to test the most basic form of a "contains" method - exact matches only in capitalization, with spaces between words as expected

2. User inputs a sentence, and the program returns how many words are in the sentence.
 - Input: "This is a test"
 - Output: 4

         Spec #2's input/output is designed to be the simpliest version of a word counter - normal spacing between words and no non-alphanumeric symbols

3. User inputs a sentence and a word, and the program returns how many times the word is contained in the sentence. 
- Input: "This is a test test", "test"
- Output: 2

         Spec #3's input/output once again using normal spacing/capitalization to find the number of occurances input word in the given sentence

4. User inputs a sentence and a word, and the program returns how many times the word is contained in the sentence, ignoring differences in capitalization and spacing.
- Input: "This is a programTeST tEst", "teSt"
- Output: 2

         Spec #4's input/output is designed to account for irregular spacing and capitalization in the input - the inputs will test for each letter ("t, "e" "s", "t") in the given word being an alternative capitalization than in the given sentence. 
