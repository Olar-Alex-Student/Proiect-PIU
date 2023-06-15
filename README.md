# Proiect PIU
## Aplicatie de gestiune a veniturilor si cheltuielilor unei persoane

O aplicatie simpla in care utilizatorul isi poate tine evidenta cheltuielilor si a veniturilor.

Proiectul isi propune sa realizeze o aplicatie care poate fi pornita cu **Terminal** si **Windows Form**.

Pentru aplicatia de tip **Windows Form** utilizatorul este intampinat cu o interfata minimalista incare sunt expuse urmatoarele:

1. Suma Contului
2. Tabelul cu gestiunea cheltuielilor si veniturilor
3. Butonul de selectare a sumei introduse
4. Camp de descriere a sumei introduse
5. Butoane radio pentru tipul sumei (Venit/Cheltuiala)
6. Butoane de adaugare a sumei si afisare a gestiunilor din tabel

Pentru aplicatia de tip **Terminal** utilizatorul este intampinat cu o interfata minimalista incare sunt expuse urmatoarele:

1. Vizualizare Suma Cont
2. Adaugare Venit
3. Adaugare Cheltuieli
4. Afisare Gestiune Din Fisier
5. Exit

Clasele folosite in aplicatie sunt:

1. Cont
2. Tranzactie

Si sunt implementate in proiectele componente aplicatiei dupa cum urmeaza:

1. Cont Utilizator
2. Gestiune-Venituri-Si-Cheltuieli
3. InterfataUtilizator_WindowsForms
4. Nivel Stocare Date

Datele introduse de utilizator sunt salvate intr-un fisier de tip **.txt** pentru a putea fi utilizate la afisarea sumei contului utilizator.

Datele se salveaza ca un sir de caractere cu separatorul **";"** intre fiecare variabila existenta. Acest lucru va usura modul de extragere a datelor pentru a putea fi afisate sau editate.

In momentul extragerii datelor din fisier clasa **Cont** is va atribui suma in conformitate cu veniturile si cheltuielile introduse.

Fiecare modificare a fisierului se face print-o lista de obiecte de tip **Tranzactie**, fiecare linie din fisier fiind o clasa de tip **Tranzactie**.

Aplicatia are caracteristica de **Validare** a datelor introduse in campurile acesteia. Daca un camp obligatoriu nu este completat sau nu are o valoare valida, programul va afisa un `MesageBox` unde i se va spune utilizatorului ca datele sunt invalide si trebuie reintroduse.