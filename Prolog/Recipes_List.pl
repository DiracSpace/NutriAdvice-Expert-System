receta('sandwich de jamon',50,'http://aasasasdasdasd').

ingrediente('pan',2,'rebanada','sandwich de jamon').
ingrediente('jamon',1,'rebanada','sandwich de jamon').
ingrediente('queso',1,'rebanada','sandwich de jamon').

tipo('sandwich de jamon','cena').
tipo('sandwich de jamon','comida').

receta('pizza',100,'http://aasasasdasdasd').

ingrediente('pan',1,'disco','pizza').
ingrediente('queso',300,'g.','pizza').

tipo('pizza','comida').

receta('Crepes salados con huevo frito',150,'https://www.foodspring.es/magazine/recetas-fitness/crepes-salados-con-huevo-frito').

ingrediente('Tortitas proteicas',40,'g.','Crepes salados con huevo frito').

tipo('Crepes salados con huevo frito','desayuno').

contiene(CE,T,R,CS,L,I,C,M):-receta(R,CS,L),tipo(R,T),ingrediente(I,C,M,R),filtro(CE,R,L).

filtro(CA,R,L):-receta(R,C,L),C=<CA.