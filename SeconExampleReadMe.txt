 

Write a psychotherapist program that continuously reads a text from the user and then gives a response based on some rules and keywords in the text until the user enters "I have to go now.".

This problem falls under the domain of Artificial Intelligence. The program will simulate the behavior of a psychotherapist. The user (patient) starts the conversation by writing a text. Then the computer (psychotherapist) asks a question related to the text. 

The program should interact with user in simple English language and simulate a conversation as a type of chatbot.

The program should ignore 14 punctuation marks, which are stored in the array punctuations, such as points, comma, semi comma, single and double quotation marks, question marks, exclamation points, dash and brackets.
 
char[] punctuations = {′.′, ′,′, ′;′, ′’′,′”′, ′?′, ′!′, ′-′, ′{′, ′}′, ′(′, ′)′, ′[′, ′]′}

Make sure your program works well, when the user uses uppercase or lower case letters, or mixes them up.

The program should apply the rules in the following order.  

Rules: 

Rule 1- If a word X (except stop words) appears more than 2 times in the text, the computer asks "Do you love X?"

Assume that stop words are stored in the following array:  

string[] stop_words = {″a″, ″after″, ″again, ″all″, ″am″, ″and″, ″any″, ″are″, ″as″, ″at″, ″be″, ″been″, ″before″, ″between″, ″both″, ″but″, ″by″, ″can″, ″could″, ″for″, ″from″, ″had″, ″has″, ″he″, ″her″, ″here″, ″him″, ″in″, ″into″, ”I”, ″is″, ″it″, ″me″, ″my″, ″of″, ″on″, ″our″, ″she″, ″so″, ″such″, ″than″, ″that″, ″the″, ″then″, ″they″, ″this″, ″to″, ″until″, ″we″, ″was″, ″were″, ″with″, ″you″}

If more than one word appears more than 2 times, select any of them.  


Rule 2- If the user asks a question to the computer with one of the following keywords: Why, Who, When, Where, What and How, the computer replies by randomly selecting one of the following questions: 

"Do you often think about this question?" 
"Why do you want to know?"


Rule 3- If the user uses one of the negative words (X), which are stored in the array negative_words, the computer asks "Being X is bad for your health. How long do you feel X? Why do you feel X?"

Assume that negative words are stored in the following array:  

string[] negative_words = {″stress″, ″depression″, ″sad″, ″angry″, ″hate″, ″pain″, ″abnormal″, ″abort″, abuse″, ″brittle″, ″hurt″, ″scared″, ″afraid″, ″upset″, ″confused″, ″lonely″, ″tired″, ″vulnerable″, ″guilty″, ″anxiety″, ″disappointment″, ″regret″, ″awful″, ″sick″, ″regretful″, ″unhappy″, ″sorrowful″, ″troubled″, ″worried″, ″annoyed″}


Rule 4- The program must convert pronouns: I with you, my with your, myself with yourself, am with are, me with you. 
The program must also remove "Yes" words if it exists and inserts whether ", right?" word or "You say" words randomly.
If the user enters more than one sentences, the program should convert the last sentence only. 




Sample Dialogue:
User    : "Hello. I am Cenk."
Program : "You are Cenk, right?"
User    : "Yes. I am feeling unhappy. I think I need a doctor."
Program : "Being unhappy is bad for your health. How long do you feel unhappy? Why do you feel unhappy?"
User    : "I feel it for a long time. I have some nightmares."
Program : "You say you have some nightmares?"
User    : "Yes. My nightmares are usually about my mother."
Program : "Your nightmares are usually about your mother, right?"
User    : "Yes. My mother always says that you should believe in your grand mother, but my mother doesn't believe in her mother herself."
Program : "Do you love mother?"
User    : "Yes. But, why my mother doesn't understand me?"
Program : "Do you often think about this question?"
User    : "Yes. She gets on my nerves sometimes."
Program : "She gets on your nerves sometimes, right?" 
User    : "Yes. Sometimes I can’t control myself!"
Program : "You say sometimes you can’t control yourself?"
User    : "I have to go now."





