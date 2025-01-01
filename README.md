<p>Ce dépôt a été créé pour pratiquer et développer des compétences en Entity Framework, services, et ASP.NET MVC, en préparation d'un examen technique. Le projet consiste en la création d'une application web de gestion des prestations de services à domicile (bricolage, jardinage, ménage, etc.).</p>

<h2>Structure du Dépôt</h2>
<ul>
    <li><strong>master</strong> : Contient toutes les modifications consolidées pour le projet.</li>
</ul>

<h2>Objectifs de l'Examen</h2>

<h3>Partie I: Entity Framework (9 points)</h3>
<ol>
    <li><strong>Création des entités et relations</strong>
        <ul>
            <li>Implémentation du diagramme de classes fourni.</li>
        </ul>
    </li>
    <li><strong>Configuration avec les annotations de données</strong>
        <ul>
            <li>Configuration des clés primaires et étrangères.</li>
            <li>Validation des propriétés (exemple : contraintes sur <code>Appreciation</code>, <code>TarifHoraire</code>, et <code>NomPrestataire</code>).</li>
        </ul>
    </li>
    <li><strong>Configuration avec Fluent API</strong>
        <ul>
            <li>Mapping des relations et des clés composées.</li>
            <li>Configuration des propriétés comme <code>HeureDebut</code>.</li>
        </ul>
    </li>
    <li><strong>Génération de la base de données</strong>
        <ul>
            <li>Nomination : <code>NomPrenomPrestation</code>.</li>
        </ul>
    </li>
    <li><strong>Mises à jour de la base de données</strong>
        <ul>
            <li>Intégration d'un type détenu <code>Coordonnees</code> dans la classe <code>Client</code>.</li>
        </ul>
    </li>
</ol>

<h3>Partie II: Services (5 points)</h3>
<ol>
    <li>Implémentation des méthodes dans la couche Service</li>
    <ul>
        <li>Retour des meilleurs prestataires et calculs de statistiques.</li>
        <li>Gestion des prestations groupées par client.</li>
        <li>Calcul des gains des prestataires.</li>
    </ul>
</ol>

<h3>Partie III: ASP.NET MVC (6 points)</h3>
<ol>
    <li><strong>Alimentation de la base de données</strong>
        <ul>
            <li>Ajout de deux spécialités et deux clients.</li>
        </ul>
    </li>
    <li><strong>Création des vues</strong>
        <ul>
            <li>Vue pour créer un prestataire avec upload de photo et liste déroulante pour la spécialité.</li>
        </ul>
    </li>
    <li><strong>Réalisation d'une vue Index</strong>
        <ul>
            <li>Affichage des meilleurs prestataires et lien vers leurs prestations.</li>
        </ul>
    </li>
</ol>

<h2>Instructions d’Utilisation</h2>
<ol>
    <li><strong>Cloner le dépôt :</strong>
        <pre><code>git clone &lt; https://github.com/FaroukBenHaj/Revision_Prestaion.git &gt;</code></pre>
    </li>
    <li><strong>Basculer sur la branche master pour travailler :</strong>
        <pre><code>git checkout master</code></pre>
    </li>
    <li><strong>Configurer la base de données :</strong>
        <ul>
            <li>Exécuter les migrations pour créer et mettre à jour la base de données.</li>
        </ul>
    </li>
    <li><strong>Déployer et tester l’application :</strong>
        <ul>
            <li>Lancer l'application avec Visual Studio ou via CLI .NET.</li>
        </ul>
    </li>
</ol>

<h2>Dépendances</h2>
<ul>
    <li>.NET Framework / .NET Core.</li>
    <li>Entity Framework.</li>
    <li>ASP.NET MVC.</li>
    <li>SQL Server (ou autre SGBD compatible).</li>
</ul>

<h2>Contribution</h2>
<p>Ce dépôt est destiné à un usage individuel pour la pratique. Toute suggestion ou question est la bienvenue.</p>
