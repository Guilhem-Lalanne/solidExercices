Evaluation finale du cours .NET à l'IUT Lyon 1
==============================================

Critères d'évaluation
---------------------

* Solution apportée aux problèmes posés dans le fichier Readme.md + réponses aux questions (à mettre dans le fichier ci-dessous)
* La qualité des commits : granularité fine et commentaires explicites du pourquoi (et non du quoi, i.e ne pas dire quels fichiers ont été modifiés, c'est inutile, Git le dit déjà)
* La qualité du code : utiliser un nommage correct + R# donne des règles à respecter, il suffit de les corriger
* Les tests unitaires : expressivité (le nommage tout particulièrement), granularité (i.e on teste une chose à la fois), rapidité (i.e instantané), couverture de code et indépendance (un test ne dépend pas des autres)
* Le design du code : utiliser les pratiques vues en cours pour éviter de faire du code difficilement maintenable et évolutif (SOLID...)

ATTENTION: ne pas changer le nommage des projets, des classes et méthodes donnés (sauf sur les tests si vous voulez).

A LA FIN DU TP: pensez à pousser vos commits sur votre compte GitHub et envoyer votre dépôt à mon adresse mail.

Réponses aux questions posées
-----------------------------

Q1) Pour éviter le switch sur l'opérateur, on peut utiliser des classes pour chaque opération.

Q2) La POO permet de cacher certains fonctionnements à d'autres parties du code ou à l'utilisateur. Il faut alors passer par les objets eux-mêmes pour accéder à leur contenu (pas d'accès direct). C'est l'encapsulation.

Q3)  C'est l'abstraction dont il est question ici. Elle permet de cacher l'utilisation de code complexe.

Q4) Principe : la classe devrait pouvoir être utilisée depuis une autre interface.
- Ici, les Console.WriteLine ne seront pas visibles depuis une interface graphique. Il faut les remplacer par un objet erreur, ou un String, qui sera utilisé selon les besoins.
- La liste des opérations est figée. Il faut éditer le code pour pouvoir la changer ... On devrait pouvoir la récupérer depuis un fichier ou une base de données.

Q5) On applique ici le principe de responsabilité unique : plutôt que d'avoir une classe qui fait plein de chose, on en fait interagir plusieurs, chacune avec ses propres responsabilités.

Q6) On utilise ici le principe de séparation des interfaces, qui permet une diminution du couplage entre les classes.
 