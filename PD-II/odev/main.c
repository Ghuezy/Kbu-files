#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <stdbool.h>
#include <conio.h>

struct Patients
{
    int patient_id;
    char identity_id[15];
    char name[50];
    int age;
    char disease[50];
};

void add_patient(FILE* file_txt, FILE* file_bin);
void delete_patient(FILE* file_txt);
void edit_patient(FILE* file_txt);
void list_patients(FILE* file_txt);
void search_patients(FILE* file_txt);

int main()
{
    int choice;
    bool go = true;

    while (go)
    {
        FILE* file_txt = fopen("patients_id.txt", "r");
        FILE* file_bin = fopen("patients_identity_id.bin", "r");

        printf("\n");
        printf("----------------------------\n");
        printf("   Patient Control System   \n");
        printf("----------------------------\n");
        printf("\n");
        printf("1 - Add patient : \n");
        printf("2 - Delete patient : \n");
        printf("3 - Edit patient : \n");
        printf("4 - List patient : \n");
        printf("5 - Search patient : \n");
        printf("0 - Exit : \n\n");
        printf("What would you like to do ? : ");
        scanf("%d", &choice);
        printf("\n");

        switch (choice)
        {
        case 1:
            add_patient(file_txt, file_bin);
            go = true;
            break;
        case 2:
            delete_patient(file_txt);
            go = true;
            break;
        case 3:
            edit_patient(file_txt);
            go = true;
            break;
        case 4:
            list_patients(file_txt);
            go = true;
            break;
        case 5:
            search_patients(file_txt);
            go = true;
            break;
        case 0:
            printf("Exiting...");
            go = false;
            break;
        default:
            break;
        }

        fclose(file_txt);
        fclose(file_bin);
    }
    getch();
    return 0;
}

void add_patient(FILE* file_txt, FILE* file_bin)
{
    struct Patients patient;
    file_txt = fopen("patients_id.txt", "a");
    file_bin = fopen("patients_identity_id.bin", "a");

    printf("Patient Id : ");
    scanf("%d", &patient.patient_id);
    printf("Identity Id : ");
    scanf("%s", patient.identity_id);
    printf("Name : ");
    scanf("%s", patient.name);
    printf("Age : ");
    scanf("%d", &patient.age);
    printf("Disease : ");
    scanf("%s", patient.disease);

    fprintf(file_txt, "%d %s %s %d %s\n", patient.patient_id, patient.identity_id, patient.name, patient.age, patient.disease);
    fprintf(file_bin, "%s %d\n", patient.identity_id, patient.patient_id);

    fclose(file_txt);
    fclose(file_bin);
}

void delete_patient(FILE* file_txt) {
    int patient_id;
    char identity_id[15];
    char name[50];
    int age;
    char disease[50];

    char search_identity[15];
    printf("Enter the Identity ID of the patient to delete: ");
    scanf("%s", search_identity);

    FILE* temp_file = fopen("temp_patients_id.txt", "w");
    if (temp_file == NULL) {
        printf("Error creating temporary file.\n");
        return;
    }

    bool found = false;
    while (fscanf(file_txt, "%d %s %s %d %s", &patient_id, identity_id, name, &age, disease) == 5) {
        if (strcmp(identity_id, search_identity) == 0) {
            found = true;
            printf("Deleting patient with Identity ID %s...\n", search_identity);
        } else {
            fprintf(temp_file, "%d %s %s %d %s\n", patient_id, identity_id, name, age, disease);
        }
    }

    fclose(file_txt);
    fclose(temp_file);

    if (!found) {
        printf("Patient with Identity ID %s not found.\n", search_identity);
    } else {
        remove("patients_id.txt");
        rename("temp_patients_id.txt", "patients_id.txt");
        printf("Patient deleted successfully.\n");
    }
}

void edit_patient(FILE* file_txt) {
    int patient_id;
    char identity_id[15];
    char name[50];
    int age;
    char disease[50];

    char search_identity[15];
    printf("Enter the Identity ID of the patient to edit: ");
    scanf("%s", search_identity);

    FILE* temp_file = fopen("temp_patients_id.txt", "w");
    if (temp_file == NULL) {
        printf("Error creating temporary file.\n");
        return;
    }

    bool found = false;
    while (fscanf(file_txt, "%d %s %s %d %s", &patient_id, identity_id, name, &age, disease) == 5) {
        if (strcmp(identity_id, search_identity) == 0) {
            found = true;
            printf("Editing patient with Identity ID %s...\n", search_identity);

            struct Patients patient;
            patient.patient_id = patient_id;
            strcpy(patient.identity_id, identity_id);
            strcpy(patient.name, name);
            patient.age = age;
            strcpy(patient.disease, disease);

            printf("Enter the new Name: ");
            scanf("%s", patient.name);
            printf("Enter the new Age: ");
            scanf("%d", &patient.age);
            printf("Enter the new Disease: ");
            scanf("%s", patient.disease);

            fprintf(temp_file, "%d %s %s %d %s\n", patient.patient_id, patient.identity_id, patient.name, patient.age, patient.disease);
            printf("Patient updated successfully.\n");
        } else {
            fprintf(temp_file, "%d %s %s %d %s\n", patient_id, identity_id, name, age, disease);
        }
    }

    fclose(file_txt);
    fclose(temp_file);

    if (!found) {
        printf("Patient with Identity ID %s not found.\n", search_identity);
    }

    remove("patients_id.txt");
    rename("temp_patients_id.txt", "patients_id.txt");
}

void list_patients(FILE* file_txt) {
    file_txt = fopen("patients_id.txt", "r");
    if (file_txt == NULL) {
        printf("Error opening patients_id.txt file.\n");
        return;
    }

    int patient_id;
    char identity_id[15];
    char name[50];
    int age;
    char disease[50];

    printf("List of Patients:\n");
    printf("-----------------\n");

    while (fscanf(file_txt, "%d %s %s %d %s", &patient_id, identity_id, name, &age, disease) == 5) {
        printf("Patient ID: %d\n", patient_id);
        printf("Identity ID: %s\n", identity_id);
        printf("Name: %s\n", name);
        printf("Age: %d\n", age);
        printf("Disease: %s\n", disease);
        printf("-----------------\n");
    }

    fclose(file_txt);
}

void search_patients(FILE* file_txt) {
    char search_identity[15];
    printf("Enter the Identity ID of the patient to search: ");
    scanf("%s", search_identity);

    int patient_id;
    char identity_id[15];
    char name[50];
    int age;
    char disease[50];

    bool found = false;

    while (fscanf(file_txt, "%d %s %s %d %s", &patient_id, identity_id, name, &age, disease) == 5) {
        if (strcmp(identity_id, search_identity) == 0) {
            found = true;
            printf("Patient Found:\n");
            printf("--------------\n");
            printf("Patient ID: %d\n", patient_id);
            printf("Identity ID: %s\n", identity_id);
            printf("Name: %s\n", name);
            printf("Age: %d\n", age);
            printf("Disease: %s\n", disease);
            printf("--------------\n");
            break;
        }
    }

    if (!found) {
        printf("Patient with Identity ID %s not found.\n", search_identity);
    }
}