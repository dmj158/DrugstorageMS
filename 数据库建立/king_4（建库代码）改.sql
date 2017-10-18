IF DB_ID('DBdrugstorage') IS NOT NULL
		DROP DATABASE DBdrugstorage;
CREATE DATABASE DBdrugstorage
		ON 
			(NAME='DataFile_1'
			,FILENAME='C:\DBdrugstorage\DataFile_1.mdf')
		LOG ON 
			(NAME='LogFile_1'
			,FILENAME='C:\DBdrugstorage\LogFile_1.ldf');
USE DBdrugstorage;
IF OBJECT_ID ('tb_MedicineType') IS NOT NULL 
		DROP TABLE tb_MedicineType ;
GO 
CREATE TABLE tb_MedicineType
	(TypeNo
		INT 
		NOT NULL 
		CONSTRAINT pk_MedicineType_No
			PRIMARY KEY(TypeNo)
	,Type 
		VARCHAR(50)
		NOT NULL);
		
IF OBJECT_ID ('tb_Medicine') IS NOT NULL 
		DROP TABLE tb_Medicine ;
GO 
CREATE TABLE tb_Medicine
	(MedicineNo 
		INT 
		NOT NULL 
		CONSTRAINT pk_Medicine_No
			PRIMARY KEY(MedicineNo)
	,MedicineName
		VARCHAR(50)
		NOT NULL
	,TypeNo
		INT 
		NOT NULL 
		CONSTRAINT fk_Medicine_TypeNo
			FOREIGN KEY(TypeNo)
			REFERENCES tb_MedicineType(No)
	,MFunction
		VARCHAR(500)
		NOT NULL 
	,PackingUnit
		VARCHAR(20)
		NOT NULL 
	,BasicDose
		VARCHAR(20)
		NOT NULL 
	,DoseUnit
		VARCHAR(10)
		NOT NULL
	, 
	Guarantee
		INT 
		NOT NULL 
	);
		
IF OBJECT_ID ('tb_User') IS NOT NULL 
		DROP TABLE tb_User ;
GO 
CREATE TABLE tb_User
	(UserNo
		INT 
		NOT NULL 
		CONSTRAINT pk_User_No
			PRIMARY KEY(UserNo)
	,UserName
		VARCHAR(20)
		NOT NULL 
	,PassCode
		VARBINARY(MAX)
		NOT NULL );
		
IF OBJECT_ID ('tb_InWarehouse') IS NOT NULL 
		DROP TABLE tb_InWarehouse;
GO 
CREATE TABLE tb_InWarehouse
	(InNo
		INT 
		NOT NULL 
		CONSTRAINT pk_InWarehouse_No
			PRIMARY KEY(No)
	,InDate
		DATE 
		NOT NULL 
	,UserNo
		INT
		NOT NULL 
		CONSTRAINT fk_InWarehouse_UserNo
			FOREIGN KEY(UserNo)
			REFERENCES tb_User(UserNo)
	,MedicineName
		INT 
		NOT NULL 
		CONSTRAINT fk_InWarehouse_MedicineNo
			FOREIGN KEY(MedicineName)
			REFERENCES tb_MEdicine(MedicineNo)
	,InAmount 
		INT 
		NOT NULL 
	,InPrice
	    FLOAT 
	    NOT NULL );
	    
IF OBJECT_ID ('tb_Pharmacy') IS NOT NULL 
		DROP TABLE tb_Pharmacy;
GO 
CREATE TABLE tb_Pharmacy		
	(PhNo 
		INT 
		NOT NULL 
		CONSTRAINT pk_Pharmacy_No
			PRIMARY KEY(PhNo)
	,Type 
		VARCHAR(10)
		NOT NULL );

IF OBJECT_ID ('tb_OutWarehouse') IS NOT NULL 
		DROP TABLE tb_OutWarehouse;
GO 
CREATE TABLE tb_OutWarehouse
	(OutNo
		INT 
		NOT NULL 
		CONSTRAINT pk_Pharmary_No
			PRIMARY KEY(OutNo)
	,PharmacyNo
		INT 
		NOT NULL 
		CONSTRAINT fk_OutWarehouse_PharmacyNo
			FOREIGN KEY(PharmacyNo)
			REFERENCES tb_Pharmacy(PhNo)	
	,MedicineNo
		INT 
		NOT NULL 
	    CONSTRAINT fk_OutWarehouse_MedicineNo
			FOREIGN KEY(MedicineNo)
	        REFERENCES tb_Medicine(No)
	,OutAmount 
		INT 
		NOT NULL 
	,OutDate 
		DATE 
		NOT NULL
        ,UserNo
		INT
		Not NULL
		CONSTRAINT fk_OutWarehouse_UserNo
			FOREIGN KEY(UserNo)
			REFERENCES tb_Pharmacy(UserNo));
		
	
IF OBJECT_ID ('tb_Checker') IS NOT NULL 
		DROP TABLE tb_Checker;
GO 
CREATE TABLE tb_Checker
	(ChNo 
		INT 
		NOT NULL
		CONSTRAINT pk_Checker_No
			PRIMARY KEY(ChNo) 
	,ChName 
		VARCHAR(20)
		NOT NULL
	);
		
IF OBJECT_ID ('tb_Stock') IS NOT NULL 
		DROP TABLE tb_Stock;
GO 
CREATE TABLE tb_Stock 
	(StockNo
		INT 
		NOT NULL 
		CONSTRAINT pk_Stock_StockNo
			PRIMARY KEY(StockNo)
	,MedicineNo
		INT 
		NOT NULL 
		CONSTRAINT fk_Stock_MedicineNo
			FOREIGN KEY(MedicineNo)
			REFERENCES tb_Medicine(MedicineNo)
	,StockAmount
		INT 
		NOT NULL 
	,InDate
		DATE 
		NOT NULL 
	,Firm
		VARCHAR(50)
		NOT NULL
	,InPrice 
		Float
		NOT NULL 
	,OutPrice 
		Float 
		NOT NULL 
	,ChNo
		INT 
		NOT NULL 
		CONSTRAINT fk_Stock_ChNo
			FOREIGN KEY(ChNo)
			REFERENCES tb_Checker(ChNo)
	,DtProduct
		DATE
		NOT NULL
	,DtFinal
		DATE
		NOT NULL);
IF OBJECT_ID('tb_Priceadjust') IS NOT NULL
	DROP TABLE tb_priceadjust;
create TABLE tb_priceadjust
	(PaNo
		INT
		NOT NULL
		CONSTRAINT pk_priceadjust_PrNo
		PRIMARY KEY(PrNo)
	,MedicineNo
		INT
		NOT NULL
		CONSTRAINT fk_Priceadjust_MedicineNo
			FOREIGN KEY(MedicineNo)
			REFERENCES tb_Medicine(MedicineNo)
	,UserNo
		INT 
		NOT NULL
		CONSTRAINT fk_Priceadjust_UserNo
			FOREIGN KEY(UserNo)
			REFERENCES tb_User(UserNo)
	,PaDate
		DATE
		NOT NUL
	,BeforePrice
		FLOAT
		NOT NULL
	,BehindPrice
		FLOAT
		NOT NULL);		
		
		
	
	

	
		
			
	


			
		