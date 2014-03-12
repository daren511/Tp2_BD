Drop table Retours;
Drop table Emprunts;
Drop table Exemplaires;
Drop table Adherents;
Drop table Livres;

CREATE TABLE Adherents
  (
    NumAdherent NUMBER NOT NULL ,
    Nom         VARCHAR2 (40) NOT NULL ,
    Prenom      VARCHAR2 (40)
  ) ;
ALTER TABLE Adherents ADD CONSTRAINT Adherents_PK PRIMARY KEY
(
  NumAdherent
)
;

CREATE TABLE Emprunts
  (
    NumPret         NUMBER NOT NULL ,
    NumExemplaire   NUMBER NOT NULL ,
    NumAdherent     NUMBER NOT NULL ,
    DateEmprunt     DATE NOT NULL ,
    DateRetour DATE
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
  NumPret NUMBER NOT NULL, 
  DateRetour DATE
  ) ;
ALTER TABLE Retours ADD CONSTRAINT Retours_PK PRIMARY KEY
(
  NumPret
)
;

ALTER TABLE Emprunts ADD CONSTRAINT Emprunts_Adherents_FK FOREIGN KEY ( NumAdherent ) REFERENCES Adherents ( NumAdherent ) ;

ALTER TABLE Emprunts ADD CONSTRAINT Emprunts_Exemplaires_FK FOREIGN KEY ( NumExemplaire ) REFERENCES Exemplaires ( NumExemplaire ) ;

ALTER TABLE Exemplaires ADD CONSTRAINT Exemplaires_Livres_FK FOREIGN KEY ( NumLivre ) REFERENCES Livres ( NumLivre ) ;

ALTER TABLE Retours ADD CONSTRAINT Retours_Emprunts_FK FOREIGN KEY ( NumPret ) REFERENCES Emprunts ( NumPret ) ;