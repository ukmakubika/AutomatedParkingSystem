INSERT INTO CLIENT(Client_FName, Client_LName, Client_IDNum, Client_Email, Client_ContactNo, Client_UserName) 
VALUES('Erling', 'Haaland', '0298765478908', 'haaland@gmail.com', '0746612356', 'Erling123')

INSERT INTO CLIENT(Client_FName, Client_LName, Client_IDNum, Client_Email, Client_ContactNo, Client_UserName) 
VALUES('Mason', 'Mount', '9915672340812', 'mount401@gmail.com', '0614578620', 'MasonM')

INSERT INTO CLIENT(Client_FName, Client_LName, Client_IDNum, Client_Email, Client_ContactNo, Client_UserName) 
VALUES('Jack', 'Grealish', '9587644129081', 'grealish@iCould.com', '0736578901', 'JG')

INSERT INTO CLIENT(Client_FName, Client_LName, Client_IDNum, Client_Email, Client_ContactNo, Client_UserName) 
VALUES('Kevin', 'De Bruyne', '9478990923081', 'kdb@gmail.com', '0786544781', 'KDB17')


INSERT INTO APP_ACCOUNT(Client_ID) VALUES ('1')

INSERT INTO APP_ACCOUNT(Client_ID) VALUES ('2')

INSERT INTO APP_ACCOUNT(Client_ID) VALUES ('3')

INSERT INTO APP_ACCOUNT(Client_ID) VALUES ('4')

INSERT INTO APP_ACCOUNT(Client_ID) VALUES ('5')


INSERT INTO REQUEST_CODE(Account_ID, Serial_Num, Price_per_hour) 
VALUES('1', '21564', '10')

INSERT INTO REQUEST_CODE(Account_ID, Serial_Num, Price_per_hour) 
VALUES('2', '56324', '40')

INSERT INTO REQUEST_CODE(Account_ID, Serial_Num, Price_per_hour) 
VALUES('3', '24976', '10')

INSERT INTO REQUEST_CODE(Account_ID, Serial_Num, Price_per_hour) 
VALUES('4', '89451', '10')

INSERT INTO REQUEST_CODE(Account_ID, Serial_Num, Price_per_hour) 
VALUES('5', '31597', '10')


/*INSERT INTO PAYMENT(Code_ID, TimeSpent, DatePayment) 
VALUES ('1', '3', '110922')

INSERT INTO PAYMENT(Code_ID, TimeSpent, DatePayment) 
VALUES ('2', '7', '120922')

INSERT INTO PAYMENT(Code_ID, TimeSpent, DatePayment) 
VALUES ('3', '4', '100922')

INSERT INTO PAYMENT(Code_ID, TimeSpent, DatePayment) 
VALUES ('4', '3', '110922')

INSERT INTO PAYMENT(Code_ID, TimeSpent, DatePayment) 
VALUES ('5', '4', '092022')*/


INSERT INTO BANK(Bank_name, Exp_date, Card_no, Card_HolderName) 
VALUES ('FNB/RMB', '0229', '0125369658412536', 'Reece James')

INSERT INTO BANK(Bank_name, Exp_date, Card_no, Card_HolderName) 
VALUES ('ABSA BANK LIMITED', '0424', '2341658956320147', 'Erling Alf-Inge')

INSERT INTO BANK(Bank_name, Exp_date, Card_no, Card_HolderName) 
VALUES ('Capitec Bank', '0128', '6521326598470125', 'Jack Grealish')



UPDATE BANK	 
SET Bank_name= 'ABSA BANK LIMITED'
WHERE Bank_ID =  1

UPDATE BANK	 
SET Bank_name = 'FNB/RMB'
WHERE Bank_ID =  2

UPDATE BANK	 
SET Bank_name = 'Investec Bank'
WHERE Bank_ID = 3



DELETE from BANK WHERE Bank_ID = '1'

DELETE from BANK WHERE Bank_ID = '3'

DELETE from BANK WHERE Bank_ID = '2'




DELETE from BANK WHERE Card_no = '" + txtDelete.Text + "'




INSERT INTO APP_ACCOUNT(Client_ID) VALUES ('1')

INSERT INTO APP_ACCOUNT(Client_ID) VALUES ('2')

INSERT INTO APP_ACCOUNT(Client_ID) VALUES ('3')

INSERT INTO APP_ACCOUNT(Client_ID) VALUES ('4')

INSERT INTO APP_ACCOUNT(Client_ID) VALUES ('5')



UPDATE CLIENT 
SET Client_FName = 'Mount', Client_UserName = 'MM19'
WHERE Client_ID =  2

UPDATE CLIENT 
SET Client_UserName = 'KDB'
WHERE Client_ID =  4

UPDATE CLIENT 
SET Client_FName = 'Alf-Inge'
WHERE Client_ID =  1
