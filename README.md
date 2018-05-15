Potrzebne narzędzia:
1. git dla Windows (https://git-scm.com/download/win)
2. VisualStudio2017 (https://docs.microsoft.com/pl-pl/visualstudio/install/install-visual-studio)
3. LocalDb (instalowane wraz z VisualStudio 2017: https://stackoverflow.com/questions/42774739/how-to-install-localdb-2016-along-with-visual-studio-2017)
4. opcjonalnie SQL Management Studio 2017 (https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-2017) - opcjonalnie bo można przeglądać bazę danych z poziomu Visual Studio 2017

Aby uruchomić:
1. Z poziomu wiersza poleceń Windows (cmd.exe) przejśc do folderu do którego zostanie skolonwana solucja
2. Wpisać komendę: git clone https://github.com/ptk86/PracowniaPsychotechniczna.git
3. Otworzyć solucję w VisualStudio2017
4. Otowrzyć Package Manager Console (ALT + T, N, O)
5. W Package Manager Console wpisać komendę: Update-Database (zostanie stworzona baza danych PracowniaPsychologoczna na instancji: (localdb)\mssqllocaldb)

Aby przeglądać bazę danych PracowniaPsychologiczna:
Wejśc do SQL Management Studio i połączyć się z serwerem (localdb)\mssqllocaldb przez Windows Authentication  
                                    LUB
Wejść do ServerExplorer (CTRL + W, L) z poziomu VisualStudio 2017 i dodać DataConnection. 
W formularzu dodawania Data Connection jako Server name podać: (localdb)\mssqllocaldb
i  jako bazę danych (Select or entrer database name) podać PracowniaPsychologiczna.
Później trzeba kliknąć dwa razy na dodanym Data Connection'nie i można przeglądać tabelki w zakładce Tables.
Dodatkowo po kliknięciu prawym przyciskiem myszy na nazwie tabelki i wybraniu "New Query" można pisać wyrażenia SQL. 

UWAGA: Baza danych PracowniaPsychologiczna nie będzie dostępna dopuki nie zostanie odpalona komenda Udtate-Database (punkt 5 w "Aby uruchomić")
