

In Turkey, students are admitted to University Bachelor (Undergraduate) Programs based on the exam results obtained from YKS (Yükseköğretim Kurumları Sınavı - Higher Education Institutions Examination). 

Write a program that simulates a university entrance exam with candidates, their exam answers, their department choices and the placement of the candidates to their desired departments.

The score of each candidate is calculated by taking into consideration the performances of applicants in the exam. There are 20 questions in the exam. Every correct answer is graded as 5 points, so the maximum grade is 100. The candidate loses 2 points for each wrong answer. Empty answers will not affect the grading. The program should calculate and print the scores of all candidates on the screen. 

Candidates are required to get a minimum score of 50 in the exam for enrolling in undergraduate programs. 

The candidates are placed in the department of their choice within the available quota. Each candidate specifies at most three department choices to where he/she wishes to enroll. Assume that the quota of all departments is 4. 

The number of departments is dynamic (maximum 7). 
The number of candidates is dynamic (maximum 30).
 
If the grades of two or more candidates are equal, the program can assign any of them to the department. 

The program should print the results of department assignments on the screen. 

Don't use automatic array related commands such as Array.Sort()

Assume that data is stored in the following arrays:  
-key
-answers
-candidates     
-departments  

Don’t change the columns and names of these arrays (key, answers, candidates, departments). 

Example arrays: 
The correct answers of the exam:
char[] key    =  {'A','D','B','C','D','C','D','A','B','C','A','B','A','A','B','A','C','A','D','D'};

The answers of the candidates: 
char[,] answers={{'A','D','B','B',' ','C','A','A','B',' ','A','B','A','A','A','A','C','A','C','D'},                                                    
                 {'A','B','B','C','D','C','D','A','B','C','D','B','A','A','B','A','C','A','C','D'}, 
                 {'A','D','A','B','D','C','A','A','B','C','A','B','A','B',' ','C','C','A',' ','D'}, 
                 {'A',' ','B','C','D','C','D','A','B','C','A','B','A',' ','B','A','C','A','D','D'}, 
                   ... };

The candidates:    (number, name & surname, choice1, choice2, choice3)
string[,] candidates = {{"2005","Ali Terim","4","6","1"}, 
                        {"1844","Ece Yaman","1","4",""}, 
                        {"3020","Ege Soylu","5","",""},                                       
                        {"2280","Ahmet Akkoyun","1","3","5"},
                          ... };

The departments:   (no, department name) 
string[,] departments = {{"1","COMPUTER ENGINEERING"}, 
                         {"2","ELECTRONICS ENGINEERING"}, 
                         {"3","MEDICINE"},                                       
                         {"4","DENTISTRY"},
                          ... };
The output of the program: 

Print the scores of all candidates on the screen

For example: 

Number   Name & Surname    Score    
2005     Ali Terim           62     
1844     Ece Yaman           94      
3020     Ege Soylu           55                             
2280     Ahmet Akkoyun       90 
…	     …                                       …


Print the results of department assignments

For example: 

No   Department                Students       
1    COMPUTER ENGINEERING      1844   2280   1122    4214
2    ELECTRONICS ENGINEERING   3310   1446   2660         
3    MEDICINE                  5577   7100   4411    2323    
4    DENTISTRY                 1000   3355   8788    1144
5    MATHEMATICS               2662   4345   
…      …                                                     …           …           …             …

