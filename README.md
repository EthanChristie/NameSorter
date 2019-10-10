# NameSorter
Small sample app that orders names alphabetically, first by last name, and then by any given names they might have

### Example Usage
Given a a file called `unsorted-names-list.txt` containing the following list of names
```
Randolph Wirtz
Inga Hudon
Angelo Sauls
Awilda Ogrady
Alida Amerson
Sophia Connon
Senaida Mutch
Cindie Arnold Mutch
Cindie Barnold Mutch
Lyman Clatterbuck
```
Executing the program in the following way;
`dotnet run ./unsorted-names-list.txt`

Will output the following sorted names to screen
```
Alida Amerson
Lyman Clatterbuck
Sophia Connon
Inga Hudon
Cindie Arnold Mutch
Cindie Barnold Mutch
Senaida Mutch
Awilda Ogrady
Angelo Sauls
Randolph Wirtz
```
and a file in the working directory called `sorted-names-list.txt` containing the sorted names.
