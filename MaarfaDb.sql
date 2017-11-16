--------------------------( Table USERS )-------------------------------------

CREATE TABLE	USERS (
	USER_ID				BIGINT	IDENTITY(1,1),
	USER_NAME			VARCHAR(30)NOT NULL, 
	PASSWORD			VARCHAR(30)NOT NULL, 
	FULL_NAME_AR		VARCHAR(90)NOT NULL, 
	FULL_NAME_EN		VARCHAR(90)NOT NULL, 
	GENDER				SMALLINT	NOT NULL,
	ID_NO				BIGINT	,
	NATION_ID			SMALLINT	NOT NULL,
	MOBILE				VARCHAR(20), 
	ADDRESS				VARCHAR(200), 
	EMAIL				VARCHAR(100)NOT NULL, 
	JOB_NAME			VARCHAR(50)NOT NULL, 
	DISCOUNT			SMALLINT	NOT NULL,
	ROLE_ID				BIGINT	,
	STATUS				SMALLINT	NOT NULL,			
	CREATE_USER			BIGINT	NOT NULL,
	CREATE_PC			VARCHAR(20)NOT NULL, 
	CREATE_TIMESTAMP	DATETIME 	NOT NULL,
	LUPDATE_USER		BIGINT	NOT NULL,
	LUPDATE_PC			VARCHAR(20)NOT NULL, 
	LUPDATE_TIMESTAMP	DATETIME 	NOT NULL,
	TRANS_STATUS		SMALLINT	NOT NULL	,
	RECORD_STATUS		SMALLINT	NOT NULL	,
	CHECK (LEN(CREATE_TIMESTAMP)=14),
	CHECK (LEN(LUPDATE_TIMESTAMP)=14),
	CHECK (LEN(PASSWORD)>3),
	CHECK (LEN(USER_NAME)>3),
	CONSTRAINT USERS_PK				PRIMARY KEY (USER_ID),
	CONSTRAINT USERS_NAME_UNIQUE	UNIQUE (USER_NAME),
	CONSTRAINT USERS_CREATE_USER	FOREIGN KEY (CREATE_USER)	REFERENCES USERS (USER_ID),
	CONSTRAINT USERS_UPDATE_USER	FOREIGN KEY (LUPDATE_USER)	REFERENCES USERS (USER_ID)
);
--*************************************************************************--
--------------------------( Table NATIONS )-------------------------------------
CREATE TABLE	NATIONS (
	NATION_ID			BIGINT	IDENTITY(1,1),
	NATION_NAME_AR		VARCHAR(30)NOT NULL, 
	NATION_NAME_EN		VARCHAR(30)NOT NULL, 
	CREATE_USER			BIGINT	NOT NULL,
	CREATE_PC			VARCHAR(20)NOT NULL, 
	CREATE_TIMESTAMP	BIGINT	NOT NULL,
	LUPDATE_USER		BIGINT	NOT NULL,
	LUPDATE_PC			VARCHAR(20)NOT NULL, 
	LUPDATE_TIMESTAMP	DATETIME	NOT NULL,
	TRANS_STATUS		SMALLINT	NOT NULL	,
	RECORD_STATUS		SMALLINT	NOT NULL	,
	CHECK (LEN(CREATE_TIMESTAMP)=14),
	CHECK (LEN(LUPDATE_TIMESTAMP)=14),
	CONSTRAINT NATIONS_PK			PRIMARY KEY (NATION_ID),
	CONSTRAINT NATIONS_CREATE_USER	FOREIGN KEY (CREATE_USER)		REFERENCES USERS (USER_ID),
	CONSTRAINT NATIONS_UPDATE_USER	FOREIGN KEY (LUPDATE_USER)	REFERENCES USERS (USER_ID)
);

--*************************************************************************--
--------------------------( Table OBJECTS )-------------------------------------
CREATE TABLE	OBJECTS	(
	OBJECT_ID			BIGINT IDENTITY(1,1),
	OBJECT_NAME_AR		VARCHAR(50)NOT NULL UNIQUE,
	OBJECT_NAME_EN		VARCHAR(50) ,
	OBJECT_COMMAND		VARCHAR(100) ,
	OBJECT_TYPE			SMALLINT	NOT NULL,
	PARNT_OBJECT		BIGINT ,
	SHOWTOOLBAR			SMALLINT	DEFAULT 0,
	MENU_ICON			VARCHAR(100) ,
	TOOLBAR_ICON		VARCHAR(100) ,
	CREATE_USER			BIGINT	NOT NULL,
	CREATE_PC			VARCHAR(20)NOT NULL, 
	CREATE_TIMESTAMP	DATETIME	NOT NULL,
	LUPDATE_USER		BIGINT	NOT NULL,
	LUPDATE_PC			VARCHAR(20)NOT NULL, 
	LUPDATE_TIMESTAMP	DATETIME	NOT NULL,
	TRANS_STATUS		SMALLINT	NOT NULL	,
	RECORD_STATUS		SMALLINT	NOT NULL	,
	CONSTRAINT OBJECT_PK			PRIMARY KEY (OBJECT_ID),
	CONSTRAINT OBJECT_OBJECT_FK		FOREIGN KEY (PARNT_OBJECT)		REFERENCES OBJECTS (OBJECT_ID),
	CONSTRAINT OBJECT_CREATE_USER	FOREIGN KEY (CREATE_USER)		REFERENCES USERS (USER_ID),
	CONSTRAINT OBJECT_UPDATE_USER	FOREIGN KEY (LUPDATE_USER)		REFERENCES USERS (USER_ID)
);

--*************************************************************************--
--------------------------( Table ROLES )-------------------------------------
CREATE TABLE ROLES	(
	ROLE_ID						BIGINT IDENTITY(1,1),
	ROLE_NAME_AR				VARCHAR(50)NOT NULL UNIQUE,
	ROLE_NAME_EN				VARCHAR(50) ,
	CREATE_USER					BIGINT	NOT NULL,
	CREATE_PC					VARCHAR(20)NOT NULL, 
	CREATE_TIMESTAMP			DATETIME	NOT NULL,
	LUPDATE_USER				BIGINT	NOT NULL,
	LUPDATE_PC					VARCHAR(20)NOT NULL, 
	LUPDATE_TIMESTAMP			DATETIME	NOT NULL,
	TRANS_STATUS				SMALLINT	NOT NULL	,
	RECORD_STATUS				SMALLINT	NOT NULL	,
	CONSTRAINT ROLE_PK			PRIMARY KEY (ROLE_ID),
	CONSTRAINT ROLE_CREATE_USER	FOREIGN KEY (CREATE_USER)			REFERENCES USERS (USER_ID),
	CONSTRAINT ROLE_UPDATE_USER	FOREIGN KEY (LUPDATE_USER)		REFERENCES USERS (USER_ID)
);
--*************************************************************************--
--*************************************************************************--
--------------------------( Table PRIVILEGES )-------------------------------------
CREATE TABLE PRIVILEGE	(
	OBJECT_ID					BIGINT ,
	ROLE_ID						BIGINT ,
	OBJECT_PRIVILEGE			VARCHAR(10)DEFAULT('0000000000'),
	CREATE_USER					BIGINT	NOT NULL,
	CREATE_PC					VARCHAR(20)NOT NULL, 
	CREATE_TIMESTAMP			BIGINT	NOT NULL,
	LUPDATE_USER				BIGINT	NOT NULL,
	LUPDATE_PC					VARCHAR(20)NOT NULL, 
	LUPDATE_TIMESTAMP			DATETIME	NOT NULL,
	TRANS_STATUS				SMALLINT	NOT NULL	,
	RECORD_STATUS				SMALLINT	NOT NULL	,
	CONSTRAINT PREV_PK			PRIMARY KEY (OBJECT_ID,ROLE_ID),
	CONSTRAINT PREV_OBJECT_FK	FOREIGN KEY (OBJECT_ID)			REFERENCES OBJECTS (OBJECT_ID),
	CONSTRAINT PREV_USER_FK		FOREIGN KEY (ROLE_ID)			REFERENCES ROLES (ROLE_ID),
	CONSTRAINT PREV_CREATE_USER	FOREIGN KEY (CREATE_USER)		REFERENCES USERS (USER_ID),
	CONSTRAINT PREV_UPDATE_USER	FOREIGN KEY (LUPDATE_USER)		REFERENCES USERS (USER_ID)
);