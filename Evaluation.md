Evaluation finale du cours .NET � l'IUT Lyon 1
==============================================

Crit�res d'�valuation
---------------------

* Solution apport�e aux probl�mes pos�s dans le fichier Readme.md + r�ponses aux questions (� mettre dans le fichier ci-dessous)
* La qualit� des commits : granularit� fine et commentaires explicites du pourquoi (et non du quoi, i.e ne pas dire quels fichiers ont �t� modifi�s, c'est inutile, Git le dit d�j�)
* La qualit� du code : utiliser un nommage correct + R# donne des r�gles � respecter, il suffit de les corriger
* Les tests unitaires : expressivit� (le nommage tout particuli�rement), granularit� (i.e on teste une chose � la fois), rapidit� (i.e instantan�), couverture de code et ind�pendance (un test ne d�pend pas des autres)
* Le design du code : utiliser les pratiques vues en cours pour �viter de faire du code difficilement maintenable et �volutif (SOLID...)

ATTENTION: ne pas changer le nommage des projets, des classes et m�thodes donn�s (sauf sur les tests si vous voulez).

A LA FIN DU TP: pensez � pousser vos commits sur votre compte GitHub et envoyer votre d�p�t � mon adresse mail.

R�ponses aux questions pos�es
-----------------------------

Q1) Pour �viter le switch sur l'op�rateur, on peut utiliser des classes pour chaque op�ration.

Q2) La POO permet de cacher certains fonctionnements � d'autres parties du code ou � l'utilisateur. Il faut alors passer par les objets eux-m�mes pour acc�der � leur contenu (pas d'acc�s direct). C'est l'encapsulation.

Q3)  C'est l'abstraction dont il est question ici. Elle permet de cacher l'utilisation de code complexe.

Q4) Principe : la classe devrait pouvoir �tre utilis�e depuis une autre interface.
- Ici, les Console.WriteLine ne seront pas visibles depuis une interface graphique. Il faut les remplacer par un objet erreur, ou un String, qui sera utilis� selon les besoins.
- La liste des op�rations est fig�e. Il faut �diter le code pour pouvoir la changer ... On devrait pouvoir la r�cup�rer depuis un fichier ou une base de donn�es.

Q5) On applique ici le principe de responsabilit� unique : plut�t que d'avoir une classe qui fait plein de chose, on en fait interagir plusieurs, chacune avec ses propres responsabilit�s.

Q6) On utilise ici le principe de s�paration des interfaces, qui permet une diminution du couplage entre les classes.
 