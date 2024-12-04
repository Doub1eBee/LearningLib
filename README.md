# LearningLib
Для создания нового решения в данной директории используй команду dotnet new sln
Далее необходимо создать проекты: 1. LearningLib - библиотечный проект. 
                                  2. LearningLib.Tests - тесты для этого проекта на NUnit, 
                                  3. LearningLib.Console - консольный проект, который вызывает хотя бы один метод из LearningLib.
Для создания проекта №1 используем команду dotnet new classlib -n LearningLib, после чего создастся папка с файлом проекта LearninLib.
С помощью комнады dotnet sln add .\LearningLib добавляем проект в папке LearningLib в решение. Указанная команда должна вызываться из директории, в которой хранится решение.

Для создания проекта №2 используем команду dotnet new nunit -n LearningLib.Tests, после чего создастся папка с файлом проекта LearningLib.Tests.
С помощью комнады dotnet sln add .\LearningLib.Tests добавляем проект в папке LearningLib в решение.

Для создания проекта №3 используем команду dotnet new console -n LearningLib.Console, после чего создастся папка с файлом проекта LearninLib.
С помощью комнады dotnet sln add .\LearningLib.Console добавляем проект в папке LearningLib в решение.
