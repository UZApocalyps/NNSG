# Iterations

## itération 1

### Entités
- personne (person)
- besoin (need)
    - faim (hunger)
- bien (good)
    - food
- UI (UI)
- métier (job)
    - agriculteur (farmer)

### UI
Le joueur interagira avec le jeu via une console.
Le niveau globale des "needs", "goods", "jobs", "person" est écrit dans la console à chaque tick

### Interaction du joueur

Pour cette première itération, le but est de simuler les personnes les besoins et les biens. Le joueur peut changer le nombres de biens disponible ainsi que le nombre de personnes.

### Notion de temps

tick : unité de mesure de temps

Chaque tick fait avancer la simulation d'un pas. Le temps par défaut il y aura 1 tick par seconde. 
Le nombre de tick par seconde pourra être ajuster par l'utilisateur ce qui permet de faire avancer la simulation rapidement ou de la mettre en pause.


### Scénario d'exemple

la partie commence, avec 100 "people" et 100 de "food", 30 "people" deviennent des "farmers".

Chaque "person" commence avec son niveau de besoins aléatoire entre 0 et 100.

Le niveau de "need" baisse avec le temps (100 -> 0).

Plus le niveau de "need" est bas plus une 
"person" est susceptible de consommer un "food".

Chaque "farmer" va produire une quantité de "food" définissable par le joueur à chaque tick. 

Le joueur peut définir la quantité que produit les "farmers" par tick en faisant "food +xxx". 
Pour ajouter des "person" on fait "person +xxx". 
Les niveaux de "need" individuels ne sont pas modifiables par le joueur. 

## Itération 2

### Ajouts
- "need" (comfort,clothing,transport)
- "good" (furniture, cloth, vehicule)
- "job"(carpenter, tailor, mechanic)
- "happiness"
- croissance de la population

### comfort
Le "comfort" est un "need". Ce "need" est comblé en achetant des "furniture". Les "furnitures" sont créer par les "carpenter".


### clothing
Le "clothing" est un "need". Ce "need" est comblé en achetant des "cloth". Les "cloth" sont créer par les "tailor".


### Tansport
Le "transport" est un "need". Ce "need" est comblé en achetant des "vehicule". Les "vehicule" sont créer par les "mechanic".



### Happiness

La notion de "happiness" représente le niveau de satisfaction d'une personne entre ses différents "needs" chaque "needs" à un poid différent dans la définition de la "happiness" 

### Croissance de la population

La croissance de la population est influençée par le niveau de "happiness" global de la population.

Si le bonheur est au-dessus de la moyenne (50) il y a des nouvelles "person" qui rejoignent notre population (par tick).

Plus le niveau est haut plus le nombres de personnes augument rapidement.