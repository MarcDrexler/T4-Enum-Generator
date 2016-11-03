# Sample

this sample demonstrates how to use the **T4-Enum-Generator**

follow the instructions to see the Enum-Generator in action:

## Prerequisits

you need to have database to run the generator against.

run the following commands from the current directory to create a database with demo content:

1. restore all dependencies


    dotnet restore

2. creates the local database and seeds it with some demo data

    
    dotnet ef database update

3. (optional) see that the program is running


    dotnet run

## Usage

after you have created the database:

1. start *Visual Studio 2015*
2. navigate to file *Enums.tt* or *StaticClasses.tt*
3. save the file

expected result:

a file called *Enums.generated.cs* or *StaticClasses.generated.cs* should be created or updated according to the values in the database