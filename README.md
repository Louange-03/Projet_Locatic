# LOCATIC

Application web de gestion d'une agence de location de voitures developpee avec ASP.NET Core MVC et Entity Framework Core.

## 1. Presentation du projet

Locatic permet de gerer les elements metier principaux d'une agence de location :
- Marques
- Modeles
- Voitures
- Clients
- Reservations

Le projet suit une architecture claire (MVC + Services) avec persistance SQLite.

## 2. Technologies utilisees

- .NET 8
- ASP.NET Core MVC
- Entity Framework Core 8
- SQLite
- Razor Views
- Bootstrap 5

## 3. Structure du projet

Le code applicatif est dans le dossier Locatic :

- Controllers : endpoints MVC et orchestration des actions
- Entities : classes metier et relations
- Data : AppDbContext, migrations, seeding
- Services/Interfaces : contrats metier
- Services/Implementations : logique metier
- ViewModels : modeles utilises par les vues
- Views : pages Razor
- wwwroot : ressources statiques (css, js, images)

## 4. Modele de donnees (relations)

- Brand 1 -> n Modele
- Modele 1 -> n Car
- Client 1 -> n Reservation
- Car 1 -> n Reservation

## 5. Prerequis

- SDK .NET 8 installe
- Outil EF Core CLI installe (dotnet-ef)

Installation de dotnet-ef (si necessaire) :

```bash
dotnet tool install --global dotnet-ef --version 8.0.11
```

## 6. Installation et lancement (etapes completes)

1. Cloner le depot :

```bash
git clone https://github.com/Louange-03/Projet_Locatic.git
```

2. Se placer dans le projet web :

```bash
cd Projet_Locatic/Locatic
```

3. Restaurer les dependances :

```bash
dotnet restore
```

4. Appliquer les migrations sur la base SQLite :

```bash
dotnet ef database update
```

5. Compiler le projet :

```bash
dotnet build
```

6. Lancer l'application :

```bash
dotnet run
```

Adresse locale (selon votre environnement) :

```txt
http://localhost:5286
```

## 7. Commandes utiles

Creer une migration :

```bash
dotnet ef migrations add NomMigration
```

Mettre a jour la base :

```bash
dotnet ef database update
```

Supprimer la derniere migration :

```bash
dotnet ef migrations remove
```

Compiler :

```bash
dotnet build
```

## 8. Configuration

La chaine de connexion SQLite est configuree dans :
- Locatic/appsettings.json
- Locatic/appsettings.Development.json

Valeur par defaut :

```txt
Data Source=agence.db
```

## 9. Initialisation des donnees

Au demarrage, un seeding est execute pour inserer des donnees de base si elles n'existent pas encore (marques, modeles, voitures, clients).

## 10. Bonnes pratiques Git

- Travailler sur la branche develop
- Verifier que le projet build avant push
- Fusionner sur main seulement apres validation finale
- Ne pas versionner les fichiers de base locale et temporaires SQLite

## 11. Auteurs

- Esso Mawaki ASSIAH
- Gires TIENTCHEU
