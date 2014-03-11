Drop table Retours;
Drop table Emprunts;
Drop table Exemplaires;
Drop table Adhérents;
Drop table Livres;

CREATE TABLE Adhérents
  (
    NumAdherant NUMBER NOT NULL ,
    Nom         VARCHAR2 (40) NOT NULL ,
    Prenom      VARCHAR2 (40)
  ) ;
ALTER TABLE Adhérents ADD CONSTRAINT Adhérents_PK PRIMARY KEY
(
  NumAdherant
)
;

CREATE TABLE Emprunts
  (
    NumPret         NUMBER NOT NULL ,
    NumExemplaire   NUMBER NOT NULL ,
    NumAdherant     NUMBER NOT NULL ,
    DateEmprunt     DATE NOT NULL ,
    DateRetouPrevue DATE
  ) ;
ALTER TABLE Emprunts ADD CONSTRAINT "Prets/Retours_PK" PRIMARY KEY
(
  NumPret
)
;

CREATE TABLE Exemplaires
  (
    NumExemplaire NUMBER NOT NULL ,
    NumLivre      NUMBER NOT NULL ,
    Disponible    CHAR (1) NOT NULL
  ) ;
ALTER TABLE Exemplaires ADD CONSTRAINT Exemplaires_PK PRIMARY KEY
(
  NumExemplaire
)
;

CREATE TABLE Livres
  (
    NumLivre NUMBER NOT NULL ,
    Titre    VARCHAR2 (40) NOT NULL ,
    Auteur   VARCHAR2 (40)
  ) ;
ALTER TABLE Livres ADD CONSTRAINT Livres_PK PRIMARY KEY
(
  NumLivre
)
;

CREATE TABLE Retours
  ( 
  NumPret NUMBER NOT NULL , DateRetour DATE
  ) ;
ALTER TABLE Retours ADD CONSTRAINT Retours_PK PRIMARY KEY
(
  NumPret
)
;

ALTER TABLE Emprunts ADD CONSTRAINT Emprunts_Adhérents_FK FOREIGN KEY ( NumAdherant ) REFERENCES Adhérents ( NumAdherant ) ;

ALTER TABLE Emprunts ADD CONSTRAINT Emprunts_Exemplaires_FK FOREIGN KEY ( NumExemplaire ) REFERENCES Exemplaires ( NumExemplaire ) ;

ALTER TABLE Exemplaires ADD CONSTRAINT Exemplaires_Livres_FK FOREIGN KEY ( NumLivre ) REFERENCES Livres ( NumLivre ) ;

ALTER TABLE Retours ADD CONSTRAINT Retours_Emprunts_FK FOREIGN KEY ( NumPret ) REFERENCES Emprunts ( NumPret ) ;

--TRIGGER
create or replace 
trigger INCPRETS
BEFORE INSERT ON EMPRUNTS
for each row
BEGIN
 if :new.NUMPRET is null then select seqprets.nextval into :new.numpret from dual;
END if;
end;
--------------------
create or replace 
trigger MISEAJOURBIBLIO 
BEFORE INSERT OR DELETE OR UPDATE ON EMPRUNTS 
DECLARE MESSAGE EXCEPTION; 
 BEGIN 
 IF (TO_CHAR(SYSDATE,'DY')= 'SAM.' OR TO_CHAR(SYSDATE,'DY')= 'DIM.') 
 THEN RAISE MESSAGE; 
 END IF; 
 EXCEPTION 
 WHEN MESSAGE THEN RAISE_APPLICATION_ERROR(-20324,'ont ne met pas à jour la fin de semaine'); 
 END;
 --------------------
 create or replace 
trigger TEMPBIDON 
BEFORE INSERT OR DELETE OR UPDATE ON EMPLOYESBIDON 
DECLARE MESSAGE EXCEPTION; 
 BEGIN 
 IF (TO_CHAR(SYSDATE,'DY')= 'SAM.' OR TO_CHAR(SYSDATE,'DY')= 'DIM.') 
 THEN RAISE MESSAGE; 
 END IF; 
 EXCEPTION 
 WHEN MESSAGE THEN RAISE_APPLICATION_ERROR(-20324,'ont ne met 
pas à jour la fin de semaine'); 
 END;
 -------------------
 create or replace 
trigger TEMPNUMERO 
BEFORE INSERT ON EMPLOYESBIDON
for each row
BEGIN
 if :new.numemp is null then select SEQEMPLOYESBIDON.nextval into :new.numemp from dual;
END if;
end;
---------------------
