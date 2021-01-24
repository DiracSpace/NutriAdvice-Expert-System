% comida de Vitamina A
food(zanahorias, vitaminaA, 10).
food(albaricoques, vitaminaA, 40).
food(espinaca, vitaminaA, 10).
food(camote, vitaminaA, 200).
food(higado-de-res, vitaminaA, 200).
food(aceite-de-higado-de-bacalao, vitaminaA, 450).
food(pimiento-rojo-dulce, vitaminaA, 40).

% comida con Vitamina C
food(naranja, vitaminaC, 84).
food(fresas, vitaminaC, 30).
food(pimiento-verde-dulce, vitaminaC, 20).
food(pimiento-rojo-dulce, vitaminaC, 20).
food(kiwi, vitaminaC, 46).
food(limon, vitaminaC, 29).

% comida de Vitamina D
food(leche-enriquecida, vitaminaD, 150).
food(aceites-de-pescado, vitaminaD, 400).
food(champinones, vitaminaD, 150).
food(salmon, vitaminaD, 150).
food(caballa, vitaminaD, 170).
food(yema, vitaminaD, 322).
food(leche-de-soya, vitaminaD, 109).

% comida con tiamina
food(frijoles-secos, tiamina, 50).
food(semillas-de-girasol, tiamina, 45).
food(huevo, tiamina, 155).
food(guisantes, tiamina, 40).
food(esparragos, tiamina, 20).
food(mejillones, tiamina, 300).
food(filete-de-ternera, tiamina, 679).

% comida con niacina
food(champinones, niacina, 20).
food(atun, niacina, 120).
food(pollo, niacina, 200).
food(res, niacina, 250).
food(cachuates, niacina, 300).
food(anchoas, niacina, 190).
food(pavo, niacina, 190).

% comida con hierro
food(cereales-de-desayuno-fortificados, hierro, 307).
food(espinaca, hierro, 23).
food(tofu, hierro, 80).
food(soja, hierro, 446).
food(judias-blancas, hierro, 67).
food(chocolate-oscuro, hierro, 546).

% comida con yodo
food(sal-yodada, yodo, 5).
food(arandanos, yodo, 308).
food(huevos-hervidos, yodo, 160).
food(bacalao, yodo, 189).
food(papa-cocida, yodo, 210).
food(queso-rayado, yodo, 455).
food(camarones, yodo, 110).

% need(Man, Nutrition) :- man(Man), d(Man,Disease), ndiseases(Disease,Nutrition).
% needstoeat(bmi, Food) :- food(Food, Nutrition, Calorie), Calorie<300.