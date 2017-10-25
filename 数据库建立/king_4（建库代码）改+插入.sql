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
	(No
		INT 
		NOT NULL 
		CONSTRAINT pk_MedicineType_No
			PRIMARY KEY(No)
	,Type 
		VARCHAR(50)
		NOT NULL);
INSERT tb_MedicineType
	(No
	,Type)
	VALUES
	('1','抗胆碱药')
	,('2','抗肾上腺素药')
	,('3','镇静催眠药')
	,('4','抗高血压药');

		
IF OBJECT_ID ('tb_Medicine') IS NOT NULL 
		DROP TABLE tb_Medicine ;
GO 
CREATE TABLE tb_Medicine
	(No 
		INT 
		NOT NULL 
		CONSTRAINT pk_Medicine_No
			PRIMARY KEY(No)
	,Name
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
		VARCHAR(MAX) 
		NOT NULL 
	);
INSERT tb_Medicine
	(No
	,Name
	,TypeNo
	,MFunction
	,PackingUnit
	,BasicDose
	,DoseUnit
	,Guarantee)
	VALUES
	('1','硫酸阿托品片','1','内脏绞痛，有机磷酸酯类中毒','瓶','1.5','mg','48个月')
,('2','氢溴酸东莨菪碱片','1','麻醉前给药，感染性休克','瓶','1','mg','24个月')
,('3','溴甲贝那替秦片','1','胃及十二指肠溃疡，胃酸过多症','瓶','45','mg','24个月')
,('4','甲磺酸酚妥拉明片','2','用于勃起功能障碍的治疗','瓶','40','mg','48个月')
,('5','盐酸哌唑嗪片','2','轻，中度高血压','瓶','2','mg','36个月')
,('6','盐酸普萘洛尔片?','2','高血压，心肌梗死','瓶','120','mg','36个月')
,('7','地西泮片','3','抗焦虑，镇静，催眠','瓶','5','mg','48个月')
,('8','阿普唑仑片','3','抗焦虑，抗抑郁','瓶','1.2','mg','36个月')
,('9','三唑仑片','3','镇静催眠','瓶','0.5','mg','36个月')
,('10','氢氯噻嗪片','4','高血压，水肿性疾病','瓶','30','mg','24个月')
,('11','硝苯地平片','4','心绞痛，高血压','瓶','50','mg','36个月')
,('12','氯沙坦钾片','4','高血压','瓶','50','mg','36个月');


		
IF OBJECT_ID ('tb_User') IS NOT NULL 
		DROP TABLE tb_User ;
GO 
CREATE TABLE tb_User
	(No
		INT 
		NOT NULL 
		CONSTRAINT pk_User_No
			PRIMARY KEY(No)
	,Name
		VARCHAR(20)
		NOT NULL 
	,PassCode
		VARCHAR(MAX)
		NOT NULL );
INSERT tb_User
	(No
	,Name
	,PassCode)
	VALUES
('1','admin1','123')
,('2','admin2','123');


		
IF OBJECT_ID ('tb_InWarehouse') IS NOT NULL 
		DROP TABLE tb_InWarehouse;
GO 
CREATE TABLE tb_InWarehouse
	(InNo
		INT 
		NOT NULL 
		CONSTRAINT pk_InWarehouse_No
			PRIMARY KEY(InNo)
	,InDate
		DATE 
		NOT NULL 
	,UserNo
		INT
		NOT NULL 
		CONSTRAINT fk_InWarehouse_UserNo
			FOREIGN KEY(UserNo)
			REFERENCES tb_User(No)
	,MedicineNo
		INT  
		NOT NULL 
		CONSTRAINT fk_InWarehouse_MedicineNo
			FOREIGN KEY(MedicineNo)
			REFERENCES tb_Medicine(No)
	,InAmount 
		INT 
		NOT NULL 
	,InPrice
	    FLOAT 
	    NOT NULL );
INSERT tb_InWarehouse
(InNo
,InDate
,UserNo
,MedicineNo
,InAmount
,InPrice)
VALUES
('171016001','2017.10.16','1','1','300','25')
,('171016002','2017.10.16','2','2','300','15');

	    
IF OBJECT_ID ('tb_Pharmacy') IS NOT NULL 
		DROP TABLE tb_Pharmacy;
GO 
CREATE TABLE tb_Pharmacy		
	(No 
		INT 
		NOT NULL 
		CONSTRAINT pk_Pharmacy_No
			PRIMARY KEY(No)
	,Type 
		VARCHAR(10)
		NOT NULL );
INSERT tb_Pharmacy
(No
,Type)
VALUES
('01','门诊药房')
,('02','住院药房');

IF OBJECT_ID ('tb_OutWarehouse') IS NOT NULL 
		DROP TABLE tb_OutWarehouse;
GO 
CREATE TABLE tb_OutWarehouse
	(OutNo
		INT 
		NOT NULL 
		CONSTRAINT pk_Pharmary_No
			PRIMARY KEY(OutNo)
	,PhNo
		INT 
		NOT NULL 
		CONSTRAINT fk_OutWarehouse_PhNo
			FOREIGN KEY(PhNo)
			REFERENCES tb_Pharmacy(No)	
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
			REFERENCES tb_User(No));
INSERT tb_OutWarehouse
(OutNo
,PhNo
,MedicineNo
,OutAmount
,OutDate
,UserNo)
VALUES
('171016001','1','1','50','1996.10.16','1')
,('171016002','2','2','30','1996.10.16','1');

		
	
IF OBJECT_ID ('tb_Checker') IS NOT NULL 
		DROP TABLE tb_Checker;
GO 
CREATE TABLE tb_Checker
	(No 
		INT 
		NOT NULL
		CONSTRAINT pk_Checker_No
			PRIMARY KEY(No) 
	,ChName 
		VARCHAR(20)
		NOT NULL
	);
INSERT tb_Checker
(No
,ChName)
VALUES
('1','李白')
,('2','黄忠');

		
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
			REFERENCES tb_Medicine(No)
	,StockAmount
		INT 
		NOT NULL 
	,InDate
		DATE 
		NOT NULL 
	,Firm
		VARCHAR(MAX)
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
			REFERENCES tb_Checker(No)
	,DtProduct
		DATE
		NOT NULL
	,DtFinal
		DATE
		NOT NULL);
INSERT tb_Stock
(StockNo
,MedicineNo
,StockAmount
,InDate
,Firm
,InPrice
,OutPrice
,ChNo
,DtProduct
,DtFinal)
VALUES
('1','1','1000','2017.10.16','杭州默沙东制药有限公司','30','40','1','2017.09.30','2019.09.30')
,('2','2','800','2017.10.16','浙江六和制药厂','25','45','1','2017.09.30','2018.09.30');

IF OBJECT_ID('tb_priceadjust') IS NOT NULL
	DROP TABLE tb_priceadjust;
create TABLE tb_priceadjust
	(PANo
		INT
		NOT NULL
		CONSTRAINT pk_priceadjust_PrNo
		PRIMARY KEY(PANo)
	,MedicineNo
		INT
		NOT NULL
		CONSTRAINT fk_Priceadjust_MedicineNo
			FOREIGN KEY(MedicineNo)
			REFERENCES tb_Medicine(No)
	,UserNo
		INT 
		NOT NULL
		CONSTRAINT fk_Priceadjust_UserNo
			FOREIGN KEY(UserNo)
			REFERENCES tb_User(No)
	,PADate
		DATE
		NOT NULL
	,BeforePrice
		FLOAT
		NOT NULL
	,BehindPrice
		FLOAT
		NOT NULL);
INSERT tb_priceadjust	
(PANo
,MedicineNo
,UserNo
,PADate
,BeforePrice
,BehindPrice)
VALUES
('1','1','1','2017.10.16','40','39')
,('2','2','1','2017.10.16','45','42');
	
		
		
	
	

	
		
			
	


			
		