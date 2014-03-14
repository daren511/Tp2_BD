EXECUTE gestionadherents.insertion('Cote','Francis');
EXECUTE gestionadherents.supprimer(2);
EXECUTE gestionadherents.modifadherent(1,'COTEEEEE','DDDFFFF');

Select gestionadherents.consuladherent from dual;

insert into livres values ('2','Comment contrer un daren','Francis Côté');
insert into exemplaires values ('11','1',1);
insert into exemplaires values ('12','1',1);

EXECUTE gestionemprunts.insertion('11','2','14-03-13','14-03-20');
EXECUTE gestionemprunts.supprimer('3');
EXECUTE gestionemprunts.modifemprunt('4','12','14-03-14','14-03-28');
Select gestionemprunts.consultemprunts from dual;

EXECUTE  gestionlivres.insertion('6','Comment flatter un daren','Daren Ken');
EXECUTE  gestionlivres.supprimer('4');
EXECUTE gestionlivres.modiflivre('2','Comment laver un daren','Daren Ken');

Select gestionlivres.consultlivre from dual;

EXECUTE gestionretours.insertion('2','14-03-28');
EXECUTE gestionretours.supprimer('4');
execute gestionretours.modifretour('4','14-04-30');
select gestionretours.consulretour from dual;




