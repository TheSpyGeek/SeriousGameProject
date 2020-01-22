# Game Design Document Outline

[TOC]

## Aperçu du jeu

1. **Game Concept**

2. **Genre** :  Action / Aventure

3. **Audience ciblée** :

   * Dans l'idéal : tout le monde
   * En réalité: les adolescents et les jeunes adultes
* Personnes sensibles à l’écologie qui veulent :
     * En apprendre plus sur ce sujet en s'amusant
     * Sensibiliser leur entourage de manière ludique

4. **Résumé du Game Flow** :

   Le joueur contrôle un personnage principal. Qui peut se déplacer dans 4 directions. Il peut interagir  avec des NPC dans le monde. Il va se balader dans les donjons afin d'arriver à son but et faire avancer l'histoire.

5. **Design Graphique** : Style cell-shading similaire à Zelda Wind Waker

## Gameplay et Mécaniques

1. **Progression du jeu** :

   Le joueur débloque une mécanique dans un donjon afin de vaincre des nouveaux déchets qu'il n'avait jamais rencontrés avant. Le joueur doit comprendre le dilemme lié à l'écologie.

   Plus le monde évolue en havre écologique et plus : 

   - Des NPC quittent la ville : maisons en ruine/abandonnées
   - Des NPC agriculteurs sont en difficultés
   - Des NPC sont au chômage

   A contrario :

   - L'agriculture repart et est plus saine
   - Les NPC se sentent mieux car il y a moins de pollution
   - Les aliments sont meilleurs

2. **Structure des missions / challenges**

   Plusieurs donjon pour arriver à la fin du jeu avec des boss à la fin de chaque donjon

3. **Objectifs** :

   Rendre le monde moins pollué en le nettoyant étape par étape (cf: Donjon).

4. **Play Flow** :

   Le joueur débute avec des mécaniques simples (**Exemple**: poser un déchet dans une poubelle). Plus l'histoire avance et plus le joueur débloque des éléments de gameplay (**Exemple**: compacter, mettre au composte, trier ses déchets, etc...)

5. **Mécaniques**
   1. **Physique** : Système de lancé d'objets, les ennemis sont projetés après avoir pris un coup.
   2. **Mouvement en jeu** :
      * Mouvement simple quadri-directionnel + diagonales
      * Rotation du personnage avec la souris ou le controller
   3. **Objets** : pour ramasser un objet le joueur doit s'approcher de cet objet et doit appuyer sur le bouton E.
   4. **Actions** :
      * Ramasser des déchets
      * Attaquer un monstre (déchets vivants)
      * Vider ses poubelles
      * Lancer des ennemis dans des poubelles
   5. **Combat** le joueur possède plusieurs armes, plus ou moins efficaces selon le type de déchets (ennemis) :
      - Lancé d'objets (déchets, rocher)
      - Frappe
6. **Screen Flow** : La caméra suit le personnage en vue du dessus. Elle se bloque sur les coins de la carte. Les donjons nécessitent un chargement du coup un changement d'écran à chaque donjon.
7. **Options** : Difficulté (Easy, medium, hard, no save mod) : affecte le nombre de points de vie des ennemis et les dégâts que le joueur peut encaisser.
8. **Sauvegarde** : Le joueur peut sauvegarder à tout moment mais au chargement du jeu, le personnage commencera à la dernière porte (chargement) passée.

## Histoire, Personnages et Options

1. **Histoire** : L'histoire se déroule dans un petit village "PeaceTown".

   **Intro**: Le personnage se réveille dans sa maison. Il lit un message (SMS ?) laissé par sa mère lui disant d'aller chez son grand-père.

   (**Niveau d'entraînement**) Il va donc sortir et se diriger vers chez son grand père. Pour cela, il va traverser le village dans lequel il y a énormément de déchets avec un air très pollué. Arrivé chez son grand père, il va discuter avec lui et se rendre compte que son grand père ne va pas bien du tout. Il tousse, a du mal à respirer et trouve que sa nourriture a un drôle de goût.

     Quand le PP (personnage principal) sort de la maison, il va entendre une voix.

   - Tu as remarqué à quel point ton grand-père est malade?
   - Hein !? Qui es-tu ? demande le PP
   - "Je suis la nature !" lui répond un petit être vert
   - Comment est-ce possible?
   - Je me suis incarné en cet être car l'heure est grave et je devais agir. Mais ce n'est pas important. Tu as vu que ton grand père souffrait à cause de cette pollution dans ton village?
   - Oui j'ai remarqué mais il n'est plus tout jeune c'est normal.
   
   (le PP avance jusqu'au village, quand il y arrive)
   
   - Ce n'est pas le seul regarde les habitants du village! Tu ne trouves pas qu'il y a des problèmes !? Si vous ne faites rien ton grand père va mourir et les gens du village vont tomber gravement malade aussi.
   - Mais qu'est ce que je peux faire pour arrêter ça ?
   - Rend toi à la centrale de charbon.
   
   "Transition (fondu au noir) pour se retrouver devant la centrale"
   
   - Regarde ce nuage de fumée. C'est ce qui rend tout le monde malade. Cette fumé rend les déchets vivants !
   
   ("cinématique" : les déchets prennent vie)
   
   - Tu as raison je dois arrêter ça !
   
   **Phase de gameplay** : Tutoriel du combat

2. **Dilemme** :

   - **Fermeture de la centrale à charbon :**

     - **Positif** :
       - L'air est moins pollué
       - Les NPC vont mieux
     - **Négatif** :
       - Pleins de NPC se retrouvent au chômage
       - Moins d’électricité
       - Installation de panneaux solaires qui attirent moins de monde pour le tourisme

      - **Le tri sélectif :**

            - **Avant** : 

                  - Il y a une énorme décharge qui pollue la terre et l'eau du lac

               * Les NPC sont malades à cause des aliments

         - **Positif** :

           - La décharge a beaucoup diminuée de volume
           - Des poubelles de tri sont apparues
           - Création d'emplois

         - **Négatif** :

           - Centrale de tri
           - Argent public utilisé pour le tri (augmentation des taxes)

   - **Suppression des pesticides** :

     - **Positif** :
       - Les aliments sont de meilleurs qualités
       - L'eau est meilleure pour la santé
       - Moins de nourriture est importée
       - Les NPC sont plus gentils
     - **Négatif** :
       - Moins de production de fruits et de légumes
       - Les produits de traitements sont plus chers

   3. **Environnement de jeu** :

      Il y a un village qui est central dans le monde. Il y a plusieurs donjons correspondants aux différentes zones du jeu qui aborderons chacun une problématique de l'écologie.

   4. **Personnages** :

      **Personnage principal** : Il parle aux habitants, il est plutôt jeune et insouciant.

      **NPC** : Il y a un médecin, un maire, un fermier (possède un bac à composte), un réparateur, une école.

      Des animaux dans la ville.

## Zones de jeu

1. **Niveaux** :
* Le monde évolue à chaque fois qu'un donjon est terminé par le joueur. (**Exemple**: après le premier donjon, des poubelles de tri apparaissent dans le village)
  
* **Premier donjon** : lié au tri sélectif. Le personnage apprend à trier ses déchets, il possède 2 poubelles (sur lui, lié à son inventaire avec un nombre limité de place) à ce moment la du jeu. Il doit relancer l'usine de recyclage des déchets. Le donjon est composé principalement de déchets en carton, papier, boite de conserve, aluminium, verre, ...
* **Deuxième donjon** : Arrêter le traitement des terres avec des pesticides chimiques. Donjon composé principalement de plantes que l'on ne peut battre qu'en les traitants avec des pesticides biologiques.
* **Troisième donjon** : Le joueur doit enlever le plastique présent dans l'eau.
2. **Niveau d'entraînement** : Le grand père vous donne comme mission de nettoyer sa maison.

## Interface

1. **HUD** :

   * La vie du personnage représentée avec des pommes
   * Le taux de remplissement des sacs du personnage
   * L'objet tenu en main par le personnage
   * L'Inventaire :
     * Le taux de remplissement des sacs du personnage
     * La liste des outils que le joueur possède
     * Carte du monde (mise à jour selon les zones explorées)

2. **Contrôles** :

   * Boutons de déplacement (ZQSD, Stick manette)
   * Bouton USE (E, X sur manette)
   * Bouton USE Outil (Souris ou  flèche directionnel, stick analogique)
   * Bouton Roulade (ESPACE, A sur Manette)
   * Bouton Pause (Echap, Start sur Manette)
   * Bouton inventaire (TAB, Select sur Manette)

3. **Audio, Musique et Effets sonores** :

   Musique : Style rétro

   * Assez rapide en combat (évolutive).
   * Assez calme en temps normal.
   * Musique très calme dans le village.
   * Une musique par donjon.

4. **Aide** :

   L'aide est matérialisée par un petit être vert qui incarne la nature. Il nous donne des conseils pour la suite des événements.

## Intelligence Artificiel

1. Opposant et ennemis IA

2. Personnages amicaux et fuyards

3. IA de support

## Technique

1. **Hardware cible** : PC,

2. **Moteur de jeu** : Unity Engine (Multi-plateforme, grande documentation et support)


## Design Artistique

![Zelda](images/zelda.png)