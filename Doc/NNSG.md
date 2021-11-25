# Jeu sans nom - Fiche signalétique

## Brève description

**Jeu sans nom** est un mélange entre une simulation fermée simple et un jeu de gestion. Le joueur prend le rôle du dirigeant d'un pays et ses conseillers viendront régulièrement présenter une situation et lui demander d'agir. Ces décisions pourront avoir un impact immédiat sur la simulation, en changer les règles et/ou lancer une suite d'événements. Le joueur aura aussi l'occasion de décider de lancer la construction des bâtiments pour créer des emplois. La partie simulation se concentrera sur la population qui produira et consommera des ressources.

## Fonctionnalités

### Population

Chaque membre de la population, ou *personne* pour simplifier, possède plusieurs besoins représenté par une valeur entre 0 et 100 qui baisseront lentement au fil du temps. Quand la satisfaction d'un besoin sera tombée trop bas, la personne cherchera à y répondre en dépensant de l'argent pour acheter ce dont il a besoin et s'il est disponible sur le marché.

#### Emploi

Chaque personne choisira un métier permettant de produire un certain bien qui comblera un certain besoin. En échange il recevra de l'argent qu'il pourra dépenser pour subvenir à ses propres besoins. Le nombre de place de travail disponible est limité et le joueur devra faire construire des bâtiments afin de créer de nouveaux emplois.

#### Bonheur

En fonction du nombre de besoin satisfait ou de leur niveau de satisfaction, un niveau de bonheur sera calculé pour chaque personne afin d'indiquer au joueur à quel point ses décisions ont un impact sur la simulation.

### Économie

En fonction du nombre de travailleur dans tel métier par rapport à la population totale, la demande et l'offre de certaine ressources variera. Les décisions prise par le joueur pourront changer la vitesse à laquelle les besoins pour certains bien de la population augmente ou baisse, de même que pour la vitesse de production de ces biens.

#### Les biens et leurs besoins

Chaque bien produit est associé à un besoin et y répond. Par exemple la nourriture satisfera la faim. Pour débuter avec une simulation simple, les biens ne seront pas précisément définit. La nourriture comprends toutes les denrées alimentaires possible sans s'occuper de leur genre ou de comment elles sont produites, ni de leur matière premières. 

 Voici une liste de Métier / bien / besoin de départ :

| Métier      | Bien       | Besoin      | Bâtiment           |
| :---------- | :--------- | :---------- | ------------------ |
| Agriculteur | Nourriture | Faim        | Ferme              |
| Menuisier   | Mobilier   | Confort     | Menuiserie         |
| Couturier   | Vêtements  | Habillement | Atelier de couture |
| Mécanicien  | Véhicules  | Transport   | Garage             |

#### Emplois

A l'image des biens, différents types d'emplois seront disponible. Ils produiront un bien spécifique et donneront un salaire à la personne exerçant ce métier.

#### Argent, Prix et salaires

La quantité d'argent n'est pas limitée, le revenu du joueur provient d'un impôt sur le revenu de la population.

Le prix d'un bien dépendra de l'offre et de la demande et se basera sur un prix de base.

Le revenu d'une personne dépend de son métier et de la valeur du bien qu'il produit ce qui enrichira un corps de métier et appauvrira les autres.

### Dirigeant

Le joueur aura accès à une interface permettant de suivre l'évolution de l'offre et de la demande des biens et pourra suivre chaque personne individuellement pour voir ce qu'elle fait et où en sont ses besoins.

#### Conseillers

Régulièrement un conseiller viendra solliciter le dirigeant pour l'informer d'un événement où d'une situation et lui proposera plusieurs options afin d'y remédier. C'est une partie importante de la partie jeu puisque qu'elle viendra déstabiliser la situation du joueur qui lui cherchera à maintenir un certain équilibre. (Mode bac à sable à développer avant ça pour pouvoir tester et ajuster la simulation avant de réutiliser les différentes commandes pour créer des événements)

#### Imposition

Le joueur pourra gagner lui aussi de l'argent qui proviendra d'un impôt sur le revenu de la population. Ces fonds serviront à construire des infrastructures qui créeront des emplois.

### Bâtiments

Les bâtiments que le joueur aura le choix de construire ne coûteront seulement de l'argent. (Les matières premières seront considérée comme achetée) Ils serviront à créer des emplois et donc à produire des biens.