# Game Design Document Outline



1. ## Title Page

   1. **Game Name**

      

      

2. ## Game Overview

   1. **Game Concept**

   2. **Genre** :  Action aventure

   3. **Target Audience**

      * Personnes sensible à l'Ecologie qui veulent en apprendre plus sur ce sujet la tout en s'amusant

      * Personnes sensible à l'Ecologie qui veulent sensibiliser leur entourage de manière ludique

   4. **Game Flow Summary** : 

      Le joueur contrôle un personnage principal. Qui peut se déplacer dans 4 directions. Il peut intéragir  avec des NPC dans le monde. Menu (options, inventaire, mini-map)

   5. **Look and Feel** : Style cell-shading => Zelda Wind Waker

      

3. ## Gameplay and Mechanics

   1. Gameplay

      1. **Game Progression** : 

         ​	Le joueur débloque une mécanique dans un donjon afin de vaincre des nouveaux déchets qu'il n'avait jamais rencontré avant

      2. **Mission/challenge Structure**

         Plusieurs donjon pour arriver à la fin du jeu

         Boss à la fin des donjons

      3. **Puzzle Structure**

      4. **Objectives** : 

         Rendre le monde moins pollué en le nettoyant étape par étape (cf: Donjon)

      5. **Play Flow** :

         Le joueur débute avec des mécaniques simples (exemple: juste poser un déchet dans une poubelle). Plus l'histoire avance plus le joueur débloque des élements de gameplay (exemple: compacter, mettre au composte, ...) 

   2. Mechanics

      1. **Physics** : Il y a un système de lancer d'objet, les ennemis sont projetés après avoir pris un coup
      2. **Movement in the game** : mouvement simple quadri-directionnel + diagonales
      3. **Objects** : pour rammasser un objet le joueur doit s'approcher de cet objet et doit appuyer sur un bouton E.
      4. **Actions** : rammasser des déchets, attaquer un mob (déchets vivants), vider ses poubelles, faire des roulades
      5. **Combat** le joueur possède plusieurs armes, plus ou moins efficace selon le type de déchets (ennemis), lancer des objets (exemple: déchets, rocher)
      6. **Economy**
      7. **Screen Flow** : la caméra suit le personnage en vue du dessus. Elle se bloque sur les coins de la map. Les donjons nécessite un chargement du coup un changement d'écran.

   3. **Game Options** :

      Difficulté (Easy, medium, hard, no save mod) : affecte le nombre de point de vie des ennemis et les dégats que le joueur encaisse.

   4. **Replaying  and Saving** : 

      Le joueur peut sauvegarder à tout moment mais au chargement du jeu, le personnage commencera à la dernière porte (chargement) passé.

   5. **Cheats and Easter Eggs** :  We will see later

      1. Cheats

      2. Easter Eggs

4. ## Story, Settings and Character

   1. **Story and Narrative** :

      ​	L'histoire se déroule dans un petit village "EcoTree". Le personnage principal en a marre de toute la polution et des déchets partout dans la ville. Il va donc sensibiliser les gens à l'écologie et partir s'attaquer aux gros problèmes dans ce monde (le tri, les gaz à effet de serre,  ...)

   2. **Game World** : 

      Il y  a un village qui est central dans le monde. Il y a plusieurs donjon correspondant aux différentes zones du jeu => problèmatique de l'écologie.

   3. **Characters** : 

      **Personnage principal** : il parle aux habitants, il est plutot jeune, vacciné et insouciant.

      **NPC** : Il y a un medecin, un maire, un fermier (possède un bac à composte), un réparateur, une école. 

      Des animaux dans la ville.

   

5. ## Levels

   1. **Levels** :

      * Le monde évolue à chaque fois qu'un donjon est terminé par le joueur. Exemple (après le premier donjon, des poubelles de tri apparaissent dans le village)

      * Premier donjon : lier au tri séléctif. Le personnage apprend à trier ses déchets, il possède 2 poubelles (sur lui, lié à son inventaire avec un nombre limité de place) à ce moment la du jeu. Il doit relancer l'usine de recyclage des déchets. Le donjon est composé principalement de déchets en carton, papier, boite de conserve, aluminium, verre, ...
      * Deuxième donjon : Arrêter le traitement des terres avec des pesticides chimiques. Donjon composé principalement de plantes que l'on peut battre qu'en les traitants avec des pesticides bio.
      * Troisième donjon: le joueur doit enlever le plastique présent dans l'eau

   2. **Training Level** : 

      Le grand père vous donne comme mission de nettoyer sa maison.

   

6. ## Interface

   1. **Visual System** :

      * la vie du personnage représentée avec des pommes
      * le taux de remplissement des sacs personels
      * l'objet tenu en main par le personnage
      * Inventaire :
        * le taux de remplissement des sacs personels
        * la liste des outils que le joueur possède
        * Carte du monde (mise à jour selon les zones explorées)

   2. **Control System** : 

      * Boutons de déplacement (ZQSD, Stick manette)
      * Bouton USE (E, X sur manette)
      * Bouton USE Outil (Souris ou  flèche directionnel, stick analogique)
      * Bouton Roulade (ESPACE, A sur Manette)
      * Bouton Pause (Echap, start sur Manette)
      * Bouton inventaire (TAB, Select sur Manette)

   3. **Audio, music, sound effect** :

      Music : style retro

      * assez rapide en combat  (évolutive).
      * assez calme en temps normal
      * Une musique par donjon

   4. **Help System** : 

   

7. ## Artificial Intelligence

   1. Opponent and Enemy AI

   2. Non-combat and Friendly Characters

   3. Support AI

   

8. ## Technical

   1. **Target Hardware** : 

      PC, 

   2. **Development hardware and software, including Game Engine** : 

      Unity Engine

   3. **Network requirements** : 

      Internet n'est pas nécessaire pour jouer

   

9. ## Game Art

   