CREATE TABLE CLIENT(
    Client_ID int IDENTITY(1,1) PRIMARY KEY,
    Client_FName varchar(35) NOT NULL,
    Client_LName varchar(35) NOT NULL,
    Client_IDNum varchar(13) NOT NULL,
    Client_Email varchar(35) NOT NULL,
    Client_ContactNo varchar(10) NOT NULL,
    Client_UserName varchar(35) NOT NULL,

);
	DROP TABLE BANK;
	CREATE TABLE BANK(
    Bank_ID int IDENTITY(1,1) PRIMARY KEY,
    Bank_name varchar(35) NOT NULL,
    Exp_date date NOT NULL,
    Card_no varchar(16) NOT NULL,
    Card_HolderName varchar(35) NOT NULL,

);
CREATE TABLE APP_ACCOUNT(
    Account_ID int IDENTITY(1,1) PRIMARY KEY,
    Client_ID int FOREIGN KEY REFERENCES CLIENT(Client_ID),
);
CREATE TABLE BANK_ACCOUNT(
    Bank_ID int,
    Account_ID int,
    CONSTRAINT PK_BANK_ACCOUNT PRIMARY KEY(Bank_ID, Account_ID),
    CONSTRAINT FK_BANK_ACCOUNT_APP_ACCOUNT FOREIGN KEY(Account_ID) REFERENCES APP_ACCOUNT(Account_ID),
    CONSTRAINT FK_BANK_ACCOUNT_BANK FOREIGN KEY(Bank_ID) REFERENCES BANK(Bank_ID),
);
CREATE TABLE REQUEST_CODE(
    Code_ID int IDENTITY(1,1) PRIMARY KEY,
    Account_ID int FOREIGN KEY REFERENCES APP_ACCOUNT(Account_ID),
    Serial_Num varchar(10) NOT NULL,
    Price_per_hour money NOT NULL,
);
CREATE TABLE PAYMENT(
    Payment_ID int IDENTITY(1,1) PRIMARY KEY,
    Code_ID int FOREIGN KEY REFERENCES REQUEST_CODE(Code_ID),
    TimeSpent time NOT NULL,
    DatePayment date NOT NULL,
);