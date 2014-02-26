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
  ( NumPret NUMBER NOT NULL , DateRetour DATE
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