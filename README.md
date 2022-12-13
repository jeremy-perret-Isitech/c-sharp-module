# c-sharp-module

- notes

    Question 1 : int vers short (conversion);
    
    Question 2 : enums c’est quoi ?
    
    Question 3 : Tableau multidimentionnels
    
    Question 4 : Que signifie le terme assembly, quand utiliser le mot cle “private” (cas réel);
    
    [Questionnaire C#](C#%2096eeb898e34345ddba19eac50f29ec43/Questionnaire%20C#%207a6a59aafd384bcbae937fe2bb2475db.md)
    
    o2n : “évaluation de la complexité et de l’optimisation de l’algorithme” (très simplifié).
    
    ```csharp
    int testMethode(string param) /// Signature de la méthode
    {
    	/// Corps de la méthode
    }
    ```
    
    Modulo : Reste d’une division euclidienne, on s’attend à un nombre entier.
    
    Quand ont fait une conversion, c’est un Cast.
    
    **Pas de `===` en c#.**
    
    - Les bibliothèques de classe :
        
        ```csharp
        using System;
        using System.Collections;
        ```
        
    
    Les types :
    
    .NET est composé de deux type différents: les types valeurs et les types référence
    
    - Un type valeur doit recevoir une affectation de valeur lors de sa déclaration.
    - Un type référence peut être déclaré sans affectation.
    
    Install nuget package in VS Code in cli :
    
    get package at url : [**https://www.nuget.org/](https://www.nuget.org/)** 
    
    - Type Valeur :
        
        ```csharp
        int test = 4; // instruction qui déclare une variable de type int et qui lui affecte la valeur 4
        
        int test2; // déclaration
        
        string text: // Lors de la déclaration d'une valeur, il doit recevoir 
        test2 = 10; // affection
        
        bool b1 = true; // cette instruction déclare et affecte la valeur true au booléen b1;
        bool b2 = b1; // copie de la valeur, sans aucun autre lien
        
        b1 = false;
        ```
        
    - Type référence :
        
        Les donnees des types référence sont stockés à un emplacement mémoire et un pointeur vers ces données est stocké dans la variable.
        
        Les classes et les interfaces sont des types références.
        
        Un type référence dois être instancié avec le mot `new` .
        
        ```csharp
        Test C1 = new Test();
                    C1.boolean = true;
        
                    Test C2 = C1;
        
                    C1.boolean = false;System.Collections
        
        ArrayList liste = new ArrayList();
        
        ArrayList liste2 = new Arrayist(1);
        
        ArrayList liste3 = new(); /// on peut omettre le type si il n'y a pas de parametres.
        ```
        
        Pour illustrer le fonctionnement des types références :
        
        ```csharp
        class Test
        {
        	public bool boolean;
        }
        
        Test C1 = new Test();
        
        C1.boolean = true;
        
        Test C2 = C1;
        
        C1.boolean = false; /// C2 vaux maintenant aussi false
        ```
        
    
    Les identifiants et les mot-cles :
    
    ```csharp
    string monIdentifiant; /// C'est un identifiant
    
    string MonIdentifiant
    
    string lock;  /// C'est un mot clé (propre au language)
    							/// (Ne build pas) lock est un mot clé rajouté @ devant lock pour overide
    
    if (condition)
    {
    	code 
    }
    /// Méthode ou Fonction avec des accolades ==> structure de controle
    ```
    
    Les opérateurs d’assignation :
    
    ```csharp
    int i = 4;
    i += 2; // 6
    i -= 2; // 4
    i *= 2; // 8
    i %= 2; // 0
    
    int x = 4;
    
    x is int; /// return true si x est un int
    
    o is DateTime d // renvoie true si o est de type DateTime
    								// o est convertie dans le type testé et placé dans la nouvelle variable d.
     
    var test = new Test(); /// on ne précise pas le type de variable, c'est une inférence de type
    
    const int i = 0;
    ```
    
    Les instruction de contrôle:
    
    ```csharp
    if(1 == 1) /// if évalue si 1 est égale à 1
    {
    	/// Code
    }
    ```
    
    Les boucles :
    
    ```csharp
    Array list = new Array();
    
    foreach(type a in list)
    {
    	/// Code
    }
    ```
    
    ### Les espaces de noms
    
    Declaration d’un espace de nom :
    
    ```csharp
    namespace EspaceDeNom
    {
    	class MaClasse
    	{
    	
    	}
    }
    ```
    
    - Les conversions
        
        ```csharp
        /// conversion implicite
        byte b = 12 /// byte signe sur 8 bits
        
        int i = 45; /// int signe sur 32 bits
        
        long k = i; /// long signe sur 64 bits
        
        ///
        long j = 16753573;
        
        int m = (int)j; /// conversion explicite
        ```
        
        Les enums :
        
        ```csharp
        /// Décrire le fonctionnement des enums en C# 
        enum LesJoursDeLaSemaine
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }
        
        LesJoursDeLaSemaine Weekend = LesJoursDeLaSemaine.Samedi | LesJoursDeLaSemaine.Dimanche;
        ```
        
        Les tableaux
        
        ```csharp
        int[] tableau;         // declaration
        tableau = new int[10]; // initialisation // taille limité à 10 éléments
        
        int[] tableau = new int[] {17, 65, 78, 32, 44 }; //
        ```
        
        Les tableau multidimentionnels
        
        ```csharp
        int[,] tableau = new int[1, 2];
        int[,,] tableau2 = new int[5,6,8];
        
        /// Différence entre ces deux synthaxes
        
        int[][] tableau3 = new int[3][];
        tableau3[0] = new int[] { 45, 2 };
        tableau3[1] = new int[] { 34, 34, 67, 2 };
        
        // Tentez de parcourir des tableau multidimentionnels avec des boucles fors
        ```
        
        - Les classes en C# représente la majorité des types reference.
            
            ```csharp
            class maSuperClass
            {
            	/// Code
            }
            ```
            
            On peut y ajouter des éléments : 
            
            - Des membres (Méthodes, propriétés) places entre accolades.
            - Des attributs
            - Des héritages et implémentation d’interface
            
            Les niveaux d’accès (Porté)
            
            - public : autorise l’accès pour les types de l’assemblage (assembly) et hors de l’asssembly
            - private : Autorise uniquement l’acces pour les autres membres du type (de la classe par exemple).
            - internal : Autorise l’acces pour les type d’assembly.
            - protected : Autorise l’acces uniquement pour les autres membres du type et pour les types heritant de celui-ci (dans l’assembly et en dehors de l’assembly).
            - protected internal : Autorise l’acces uniquement pour les autres membres du type et pour les types heriitant de celui-ci (dans l’assembly uniquement).
            
            Si aucune porté n’est précisé sur un membre, il est considérer comme private, une classe sans modificateur sera quand à elle est comme public.
            
        - Les Struct en C#
            
            Les struct en C# ressemble aux classes mais sont de type valeur, elles ne supporte pas l’heritage. 
            
            ```csharp
            struct Coordinates
            {
            	double Long;
            	double Lat;
            }
            
            Coordinates point = new Coordinates();
            ```
            
        - Vocabulaire sur les classes
            
            ```csharp
            public class SuperClass
            {
            	protected string myPath = "/url/toPath/";
            
            	public int MyProperty { get; set; } /// Propiété
            
            	public void WriteFile()
            	{
            		// Code
            	}
            
            	public void WriteFile(string FilePath)
            	{
            		// Code
            	}
            
            }
            
            SuperClass file = new SuperClass();
            ```

- Réponse question
    ## Questionnaire C#

    Question 1 :

    Lors de la conversion d’un type signé vers le même type ayant une architecture signé inférieur, e résultat optenu pourrait ne pas être celui attendu.

    Example, conversion d’un `short` signé en 64 bits vers un type `byte` signé en 8 bits.

    ```csharp
    short s = 300;
    byte d = (byte)s;

    Console.WriteLine("d = " + d); /// d = 44
    ```

    Dans le code ci dessus, la variable `d` de type `byte` ne peut pas contenir une valeur suppérieur à 255, car le type `byte` est signé 8 bits, sa capacité est limité à 2⁸ (256) valeurs possibles (valeur max 255 car 0 est la première valeur).

    Ici `d` vaux 44 car si la variable atteint la limite de ça capacité elle recommence à 0.

    Ce qui se passe ici :

    300 - 256 = 44

    300 est la valeur de `short s`;

    256 est la valeur max que `byte s` peut contenir;

    Question 2 :

    Le type `enum` est une classe particulière qui contient l’énumération des différentes valeurs sous forme de constante pouvant être assigné.

    Ce type est généralement assigné aux valeurs que serons pas modifiés.

    ```csharp
    /// Décrire le fonctionnement des enums en C# 
    enum LesJoursDeLaSemaine
    {
        Lundi,
        Mardi,
        Mercredi,
        Jeudi,
        Vendredi,
        Samedi,
        Dimanche
    }

    LesJoursDeLaSemaine Weekend = LesJoursDeLaSemaine.Samedi | LesJoursDeLaSemaine.Dimanche;
    ```

    Dans le code ci-dessus, la variable `Weekend`, pourra contenir uniquement la valeur `Samedi` ou `Dimanche` .

    Question 3 :

    source : learn.microsoft.com

    ```csharp
    int[,] tableau = new int[3, 5];
    int[,,] tableau2 = new int[5,6,8];

    /// Différence entre ces deux synthaxes

    int[][] tableau3 = new int[3][];
    tableau3[0] = new int[] { 45, 2 };
    tableau3[1] = new int[] { 34, 34, 67, 2 };
    ```

    Lors de la première instruction, la variable `tableau` est déclaré, c’est un tableau de `int` à 2 dimensions, initialisé avec trois colonnes et cinq lignes.

    La seconde instruction déclare et initialise la variable `tableau2`, comme étant un tableau à 3 dimensions.

    La première sintaxe montre l’initialisation de tableau à multiple dimension, avec un nombre de lignes et de colonnes défini, sans insérer de données dans celles ci.

    Lors de la troisième instruction le `tableau3` est déclaré, c’est un array dit Jagged, c’est un tableau qui contient des tableau.

    Dans les instructions suivantes un tableau de int est initialisé et inséré dans la ligne 0 et 1 du tableau `tableau3` .

    Voici un code qui permettrais de parcourir un tableau multidimentionnels avec une boucle `for`.

    ```csharp
    int[][] tableau3 = new int[3][];
    tableau3[0] = new int[] { 45, 2 };
    tableau3[1] = new int[] { 34, 34, 67, 2 };

    for(int i = 0; i < tableau3.Length; i++)
    {
        if(array[i] != null)
        {
            for(int y = 0; y < array[i].Length; y++)
            {
                    Console.WriteLine(array[i][y]);
            }
        }
    }
    ```