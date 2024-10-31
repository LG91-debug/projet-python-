
import os
import random 
from time import sleep

mapmorpion =[["7","8","9"],
             ["4","5","6"],
             ["1","2","3"]]

mapmorpionIA = [[1,1,1],
                [1,1,1],
                [1,1,1]]
coup = ["X","O"]








listecoupjoue = []
listecouppossible = ["1","2","3","4","5","6","7","8","9"]

def IAdrunk(listecoupjoue):
    listecoupIA = ["1","2","3","4","5","6","7","8","9"]

    for coup in listecoupjoue:
        listecoupIA.remove(coup)
    sleep(1)
    return random.choice(listecoupIA)



def IAsobre(mapmorpion):
    for i in range(0,3):
        for j in range(0,3):
            if mapmorpion[i][j] in coup:
                mapmorpionIA[i][j]==0



    for i in range(0,3):
        for j in range(0,3):
            if mapmorpion[i-2][j]==mapmorpion[i][j]:
                mapmorpionIA[i-1][j]=5
            if mapmorpion[i][j-2]==mapmorpion[i][j]:
                mapmorpionIA[i][j-1]=5
            
            
            # print("(",mapmorpion[i][j-2],mapmorpion[i][j],") ->",mapmorpion[i][j-1],"=5")



    affichemapIA(mapmorpionIA)

def affichemapIA(mapmorpion):
    print("mapIa")
    for i in range (0,3):
        print(mapmorpion[i])




def ecranselec():
    choix = -1
    os.system("CLS")
    print(" , ,  _, ,_  ,_  ___,  _, ,  , ")
    print("|\/| / \,|_) |_)' |   / \,|\ | ") 
    print("| `|'\_/'| \''|   _|_,'\_/ |'\| ")
    print("'  ` '   '  `'  '     '   '  ` ")
    print("1: mode 2 joueurs")
    print("2: mode 1 joueur")
    print("3: mode IA VS IA")    
    choix = int(input("entrez le mode de jeu voulu "))     
    if choix == 1:
        choix = 100
    if choix == 2:
        os.system("CLS")
        print("<- IA ->")
        print("1: IA drunk")
        print("2: IA un peu bourrée")
        print("3: IA sobre")
        print("4: super IA")
        choix = choix*10 + int(input("vous voulez jouer contre quelle IA"))
        os.system("CLS")
        print("1: oui")
        print("2: non")
        choix = choix*10 + int(input("voulez-vous commencer ?"))
        
            

    if choix == 3:
        print("quelles IA doivent s'affronter?")
        print("<- IA 1->")
        print("1: IA drunk")
        print("2: IA un peu bourrée")
        print("3: IA sobre")
        print("4: super IA")
        choix = choix*10 + int(input("selectionner IA "))
        os.system("CLS")     

        print("<- IA 2->")
        print("1: IA drunk")
        print("2: IA un peu bourrée")
        print("3: IA sobre")
        print("4: super IA")
        choix = choix*10 + int(input("selectionner IA "))        
    
    os.system("CLS")
    return choix



def FlavorIA(mapmorpion,mapmorpionIA,coup,pos):
    for i in range(0,3):
        for j in range(0,3):
            if mapmorpion[i][j] in coup:
                mapmorpionIA[i][j]=0
    if pos == 1: 
        for i in range(0,3):
            for j in range(0,3):
                if mapmorpion[i][j]!=mapmorpion[i-2][j] and mapmorpion[i-1][j] not in coup and mapmorpion[i][j]=="X" and mapmorpion[i-2][j]!="O":
                    mapmorpionIA[i-2][j]=3
                if mapmorpion[i][j]!=mapmorpion[i-1][j] and mapmorpion[i-2][j] not in coup and mapmorpion[i][j]=="X" and mapmorpion[i-1][j]!="O":
                    mapmorpionIA[i-1][j]=3
                if mapmorpion[i][j]!=mapmorpion[i][j-2] and mapmorpion[i][j-1] not in coup and mapmorpion[i][j]=="X" and mapmorpion[i][j-2]!="O":
                    mapmorpionIA[i][j-2]=3
                if mapmorpion[i][j]!=mapmorpion[i][j-1] and mapmorpion[i][j-2] not in coup and mapmorpion[i][j]=="X" and mapmorpion[i][j-1]!="O":
                    mapmorpionIA[i][j-1]=3
                if i == 1 and j == 1:
                    if mapmorpion[i][j] not in coup and mapmorpion[i+1][j+1] not in coup and mapmorpion[i][j]!=mapmorpion[i-1][j-1]:
                        mapmorpionIA[i][j]=3
                    if mapmorpion[i][j] not in coup and mapmorpion[i-1][j-1] not in coup and mapmorpion[i][j]!=mapmorpion[i+1][j+1]:
                        mapmorpionIA[i][j]=3
                    if mapmorpion[i][j] not in coup and mapmorpion[i-1][j+1] not in coup and mapmorpion[i][j]!=mapmorpion[i+1][j-1]:
                        mapmorpionIA[i][j]=3
                    if mapmorpion[i][j] not in coup and mapmorpion[i+1][j-1] not in coup and mapmorpion[i][j]!=mapmorpion[i-1][j+1]:
                        mapmorpionIA[i][j]=3
                if mapmorpion[0][0] not in coup and mapmorpion[2][2] not in coup and mapmorpion[1][1]=="X":
                    mapmorpionIA[0][0]=3
                    mapmorpionIA[2][2]=3
                if mapmorpion[0][2] not in coup and mapmorpion[2][0] not in coup and mapmorpion[1][1]=="X":
                    mapmorpionIA[0][2]=3
                    mapmorpionIA[2][0]=3




        for i in range(0,3):
            for j in range(0,3):
                if mapmorpion[i-2][j]==mapmorpion[i][j] and mapmorpion[i-1][j] not in coup:
                    mapmorpionIA[i-1][j]=5
                if mapmorpion[i][j-2]==mapmorpion[i][j] and mapmorpion[i][j-1] not in coup:
                    mapmorpionIA[i][j-1]=5
                if i==1 and j==1:
                    if mapmorpion[i][j]==mapmorpion[i-1][j-1] and mapmorpion[i+1][j+1]not in coup:
                        mapmorpionIA[i+1][j+1]=5
                    if mapmorpion[i][j]==mapmorpion[i+1][j+1] and mapmorpion[i-1][j-1]not in coup:
                        mapmorpionIA[i-1][j-1]=5
                    if mapmorpion[i][j]==mapmorpion[i-1][j+1] and mapmorpion[i+1][j-1]not in coup:
                        mapmorpionIA[i+1][j-1]=5
                    if mapmorpion[i][j]==mapmorpion[i+1][j-1] and mapmorpion[i-1][j+1]not in coup:
                        mapmorpionIA[i-1][j+1]=5
                if mapmorpion[0][0]==mapmorpion[2][2] and mapmorpion[1][1] not in coup:
                    mapmorpionIA[1][1]=5
                if mapmorpion[0][2]==mapmorpion[2][0] and mapmorpion[1][1] not in coup:
                    mapmorpionIA[1][1]=5
# joueur 2   
    else:

        for i in range(0,3):
            for j in range(0,3):
                if mapmorpion[i][j]!=mapmorpion[i-2][j] and mapmorpion[i-1][j] not in coup and mapmorpion[i][j]=="O" and mapmorpion[i-2][j]!="X":
                    mapmorpionIA[i-2][j]=3
                if mapmorpion[i][j]!=mapmorpion[i-1][j] and mapmorpion[i-2][j] not in coup and mapmorpion[i][j]=="O" and mapmorpion[i-1][j]!="X":
                    mapmorpionIA[i-1][j]=3
                if mapmorpion[i][j]!=mapmorpion[i][j-2] and mapmorpion[i][j-1] not in coup and mapmorpion[i][j]=="O" and mapmorpion[i][j-2]!="X":
                    mapmorpionIA[i][j-2]=3
                if mapmorpion[i][j]!=mapmorpion[i][j-1] and mapmorpion[i][j-2] not in coup and mapmorpion[i][j]=="O" and mapmorpion[i][j-1]!="X":
                    mapmorpionIA[i][j-1]=3
                if i == 1 and j == 1:
                    if mapmorpion[i][j] not in coup and mapmorpion[i+1][j+1] not in coup and mapmorpion[i][j]!=mapmorpion[i-1][j-1]:
                        mapmorpionIA[i][j]=3
                    if mapmorpion[i][j] not in coup and mapmorpion[i-1][j-1] not in coup and mapmorpion[i][j]!=mapmorpion[i+1][j+1]:
                        mapmorpionIA[i][j]=3
                    if mapmorpion[i][j] not in coup and mapmorpion[i-1][j+1] not in coup and mapmorpion[i][j]!=mapmorpion[i+1][j-1]:
                        mapmorpionIA[i][j]=3
                    if mapmorpion[i][j] not in coup and mapmorpion[i+1][j-1] not in coup and mapmorpion[i][j]!=mapmorpion[i-1][j+1]:
                        mapmorpionIA[i][j]=3
                if mapmorpion[0][0] not in coup and mapmorpion[2][2] not in coup and mapmorpion[1][1]=="O":
                    mapmorpionIA[0][0]=3
                    mapmorpionIA[2][2]=3
                if mapmorpion[0][2] not in coup and mapmorpion[2][0] not in coup and mapmorpion[1][1]=="O":
                    mapmorpionIA[0][2]=3
                    mapmorpionIA[2][0]=3




        for i in range(0,3):
            for j in range(0,3):
                if mapmorpion[i-2][j]==mapmorpion[i][j] and mapmorpion[i-1][j] not in coup:
                    mapmorpionIA[i-1][j]=5
                if mapmorpion[i][j-2]==mapmorpion[i][j] and mapmorpion[i][j-1] not in coup:
                    mapmorpionIA[i][j-1]=5
                if i==1 and j==1:
                    if mapmorpion[i][j]==mapmorpion[i-1][j-1] and mapmorpion[i+1][j+1]not in coup:
                        mapmorpionIA[i+1][j+1]=5
                    if mapmorpion[i][j]==mapmorpion[i+1][j+1] and mapmorpion[i-1][j-1]not in coup:
                        mapmorpionIA[i-1][j-1]=5
                    if mapmorpion[i][j]==mapmorpion[i-1][j+1] and mapmorpion[i+1][j-1]not in coup:
                        mapmorpionIA[i+1][j-1]=5
                    if mapmorpion[i][j]==mapmorpion[i+1][j-1] and mapmorpion[i-1][j+1]not in coup:
                        mapmorpionIA[i-1][j+1]=5
                if mapmorpion[0][0]==mapmorpion[2][2] and mapmorpion[1][1] not in coup:
                    mapmorpionIA[1][1]=5
                if mapmorpion[0][2]==mapmorpion[2][0] and mapmorpion[1][1] not in coup:
                    mapmorpionIA[1][1]=5

    max = -1
    for i in range(0,3):
        for j in range(0,3):
            if mapmorpionIA[i][j]>max:
                max=mapmorpionIA[i][j]
                choix=mapmorpion[i][j]
    sleep(1)
    return choix
















def possible(choix):
    exit=False
    if choix in listecouppossible and choix not in listecoupjoue:
        exit=True
    return exit

def FlavorIAnv2(mapmorpion,mapmorpionIA,coup,pos):
    for i in range(0,3):
        for j in range(0,3):
            if mapmorpion[i][j] in coup:
                mapmorpionIA[i][j]=0
    if pos == 1: 
        for i in range(0,3):
            for j in range(0,3):
                if mapmorpion[i][j]!=mapmorpion[i-2][j] and mapmorpion[i-1][j] not in coup and mapmorpion[i][j]=="X" and mapmorpion[i-2][j]!="O":
                    mapmorpionIA[i-2][j]=3
                if mapmorpion[i][j]!=mapmorpion[i-1][j] and mapmorpion[i-2][j] not in coup and mapmorpion[i][j]=="X" and mapmorpion[i-1][j]!="O":
                    mapmorpionIA[i-1][j]=3
                if mapmorpion[i][j]!=mapmorpion[i][j-2] and mapmorpion[i][j-1] not in coup and mapmorpion[i][j]=="X" and mapmorpion[i][j-2]!="O":
                    mapmorpionIA[i][j-2]=3
                if mapmorpion[i][j]!=mapmorpion[i][j-1] and mapmorpion[i][j-2] not in coup and mapmorpion[i][j]=="X" and mapmorpion[i][j-1]!="O":
                    mapmorpionIA[i][j-1]=3
                if i == 1 and j == 1:
                    if mapmorpion[i][j] not in coup and mapmorpion[i+1][j+1] not in coup and mapmorpion[i][j]!=mapmorpion[i-1][j-1]:
                        mapmorpionIA[i][j]=3
                    if mapmorpion[i][j] not in coup and mapmorpion[i-1][j-1] not in coup and mapmorpion[i][j]!=mapmorpion[i+1][j+1]:
                        mapmorpionIA[i][j]=3
                    if mapmorpion[i][j] not in coup and mapmorpion[i-1][j+1] not in coup and mapmorpion[i][j]!=mapmorpion[i+1][j-1]:
                        mapmorpionIA[i][j]=3
                    if mapmorpion[i][j] not in coup and mapmorpion[i+1][j-1] not in coup and mapmorpion[i][j]!=mapmorpion[i-1][j+1]:
                        mapmorpionIA[i][j]=3
                if mapmorpion[0][0] not in coup and mapmorpion[2][2] not in coup and mapmorpion[1][1]=="X":
                    mapmorpionIA[0][0]=3
                    mapmorpionIA[2][2]=3
                if mapmorpion[0][2] not in coup and mapmorpion[2][0] not in coup and mapmorpion[1][1]=="X":
                    mapmorpionIA[0][2]=3
                    mapmorpionIA[2][0]=3

        for i in range(0,3):
            for j in range(0,3):
                if mapmorpion[i-2][j]==mapmorpion[i][j] and mapmorpion[i][j]=="O" and mapmorpion[i-1][j] not in coup:
                    mapmorpionIA[i-1][j]=5
                if mapmorpion[i][j-2]==mapmorpion[i][j] and mapmorpion[i][j]=="O" and mapmorpion[i][j-1] not in coup:
                    mapmorpionIA[i][j-1]=5
                if i==1 and j==1:
                    if mapmorpion[i][j]==mapmorpion[i-1][j-1] and mapmorpion[i][j]=="O" and mapmorpion[i+1][j+1]not in coup:
                        mapmorpionIA[i+1][j+1]=5
                    if mapmorpion[i][j]==mapmorpion[i+1][j+1] and mapmorpion[i][j]=="O" and mapmorpion[i-1][j-1]not in coup:
                        mapmorpionIA[i-1][j-1]=5
                    if mapmorpion[i][j]==mapmorpion[i-1][j+1] and mapmorpion[i][j]=="O" and mapmorpion[i+1][j-1]not in coup:
                        mapmorpionIA[i+1][j-1]=5
                    if mapmorpion[i][j]==mapmorpion[i+1][j-1] and mapmorpion[i][j]=="O" and mapmorpion[i-1][j+1]not in coup:
                        mapmorpionIA[i-1][j+1]=5
                if mapmorpion[0][0]==mapmorpion[2][2] and mapmorpion[0][0]=="O" and mapmorpion[1][1] not in coup:
                    mapmorpionIA[1][1]=5
                if mapmorpion[0][2]==mapmorpion[2][0] and mapmorpion[0][2]=="O" and mapmorpion[1][1] not in coup:
                    mapmorpionIA[1][1]=5


        for i in range(0,3):
            for j in range(0,3):
                if mapmorpion[i-2][j]==mapmorpion[i][j] and mapmorpion[i][j]=="X" and mapmorpion[i-1][j] not in coup:
                    mapmorpionIA[i-1][j]=4
                if mapmorpion[i][j-2]==mapmorpion[i][j] and mapmorpion[i][j]=="X" and mapmorpion[i][j-1] not in coup:
                    mapmorpionIA[i][j-1]=4
                if i==1 and j==1:
                    if mapmorpion[i][j]==mapmorpion[i-1][j-1] and mapmorpion[i][j]=="X" and mapmorpion[i+1][j+1]not in coup:
                        mapmorpionIA[i+1][j+1]=4
                    if mapmorpion[i][j]==mapmorpion[i+1][j+1] and mapmorpion[i][j]=="X" and mapmorpion[i-1][j-1]not in coup:
                        mapmorpionIA[i-1][j-1]=4
                    if mapmorpion[i][j]==mapmorpion[i-1][j+1] and mapmorpion[i][j]=="X" and mapmorpion[i+1][j-1]not in coup:
                        mapmorpionIA[i+1][j-1]=4
                    if mapmorpion[i][j]==mapmorpion[i+1][j-1] and mapmorpion[i][j]=="X" and mapmorpion[i-1][j+1]not in coup:
                        mapmorpionIA[i-1][j+1]=4
                if mapmorpion[0][0]==mapmorpion[2][2] and mapmorpion[0][0]=="X" and mapmorpion[1][1] not in coup:
                    mapmorpionIA[1][1]=4
                if mapmorpion[0][2]==mapmorpion[2][0] and mapmorpion[0][2]=="X" and mapmorpion[1][1] not in coup:
                    mapmorpionIA[1][1]=4

                    

# joueur 2   
    else:

        for i in range(0,3):
            for j in range(0,3):
                if mapmorpion[i][j]!=mapmorpion[i-2][j] and mapmorpion[i-1][j] not in coup and mapmorpion[i][j]=="O" and mapmorpion[i-2][j]!="X":
                    mapmorpionIA[i-2][j]=3
                if mapmorpion[i][j]!=mapmorpion[i-1][j] and mapmorpion[i-2][j] not in coup and mapmorpion[i][j]=="O" and mapmorpion[i-1][j]!="X":
                    mapmorpionIA[i-1][j]=3
                if mapmorpion[i][j]!=mapmorpion[i][j-2] and mapmorpion[i][j-1] not in coup and mapmorpion[i][j]=="O" and mapmorpion[i][j-2]!="X":
                    mapmorpionIA[i][j-2]=3
                if mapmorpion[i][j]!=mapmorpion[i][j-1] and mapmorpion[i][j-2] not in coup and mapmorpion[i][j]=="O" and mapmorpion[i][j-1]!="X":
                    mapmorpionIA[i][j-1]=3
                if i == 1 and j == 1:
                    if mapmorpion[i][j] not in coup and mapmorpion[i+1][j+1] not in coup and mapmorpion[i][j]!=mapmorpion[i-1][j-1]:
                        mapmorpionIA[i][j]=3
                    if mapmorpion[i][j] not in coup and mapmorpion[i-1][j-1] not in coup and mapmorpion[i][j]!=mapmorpion[i+1][j+1]:
                        mapmorpionIA[i][j]=3
                    if mapmorpion[i][j] not in coup and mapmorpion[i-1][j+1] not in coup and mapmorpion[i][j]!=mapmorpion[i+1][j-1]:
                        mapmorpionIA[i][j]=3
                    if mapmorpion[i][j] not in coup and mapmorpion[i+1][j-1] not in coup and mapmorpion[i][j]!=mapmorpion[i-1][j+1]:
                        mapmorpionIA[i][j]=3
                if mapmorpion[0][0] not in coup and mapmorpion[2][2] not in coup and mapmorpion[1][1]=="O":
                    mapmorpionIA[0][0]=3
                    mapmorpionIA[2][2]=3
                if mapmorpion[0][2] not in coup and mapmorpion[2][0] not in coup and mapmorpion[1][1]=="O":
                    mapmorpionIA[0][2]=3
                    mapmorpionIA[2][0]=3

        for i in range(0,3):
            for j in range(0,3):
                if mapmorpion[i-2][j]==mapmorpion[i][j] and mapmorpion[i][j]=="X" and mapmorpion[i-1][j] not in coup:
                    mapmorpionIA[i-1][j]=4
                if mapmorpion[i][j-2]==mapmorpion[i][j] and mapmorpion[i][j]=="X" and mapmorpion[i][j-1] not in coup:
                    mapmorpionIA[i][j-1]=4
                if i==1 and j==1:
                    if mapmorpion[i][j]==mapmorpion[i-1][j-1] and mapmorpion[i][j]=="X" and mapmorpion[i+1][j+1]not in coup:
                        mapmorpionIA[i+1][j+1]=4
                    if mapmorpion[i][j]==mapmorpion[i+1][j+1] and mapmorpion[i][j]=="X" and mapmorpion[i-1][j-1]not in coup:
                        mapmorpionIA[i-1][j-1]=4
                    if mapmorpion[i][j]==mapmorpion[i-1][j+1] and mapmorpion[i][j]=="X" and mapmorpion[i+1][j-1]not in coup:
                        mapmorpionIA[i+1][j-1]=4
                    if mapmorpion[i][j]==mapmorpion[i+1][j-1] and mapmorpion[i][j]=="X" and mapmorpion[i-1][j+1]not in coup:
                        mapmorpionIA[i-1][j+1]=4
                if mapmorpion[0][0]==mapmorpion[2][2] and mapmorpion[0][0]=="X" and mapmorpion[1][1] not in coup:
                    mapmorpionIA[1][1]=4
                if mapmorpion[0][2]==mapmorpion[2][0] and mapmorpion[0][2]=="X" and mapmorpion[1][1] not in coup:
                    mapmorpionIA[1][1]=4



        for i in range(0,3):
            for j in range(0,3):
                if mapmorpion[i-2][j]==mapmorpion[i][j] and mapmorpion[i][j]=="O" and mapmorpion[i-1][j] not in coup:
                    mapmorpionIA[i-1][j]=5
                if mapmorpion[i][j-2]==mapmorpion[i][j] and mapmorpion[i][j]=="O" and mapmorpion[i][j-1] not in coup:
                    mapmorpionIA[i][j-1]=5
                if i==1 and j==1:
                    if mapmorpion[i][j]==mapmorpion[i-1][j-1] and mapmorpion[i][j]=="O" and mapmorpion[i+1][j+1]not in coup:
                        mapmorpionIA[i+1][j+1]=5
                    if mapmorpion[i][j]==mapmorpion[i+1][j+1] and mapmorpion[i][j]=="O" and mapmorpion[i-1][j-1]not in coup:
                        mapmorpionIA[i-1][j-1]=5
                    if mapmorpion[i][j]==mapmorpion[i-1][j+1] and mapmorpion[i][j]=="O" and mapmorpion[i+1][j-1]not in coup:
                        mapmorpionIA[i+1][j-1]=5
                    if mapmorpion[i][j]==mapmorpion[i+1][j-1] and mapmorpion[i][j]=="O" and mapmorpion[i-1][j+1]not in coup:
                        mapmorpionIA[i-1][j+1]=5
                if mapmorpion[0][0]==mapmorpion[2][2] and mapmorpion[0][0]=="O" and mapmorpion[1][1] not in coup:
                    mapmorpionIA[1][1]=5
                if mapmorpion[0][2]==mapmorpion[2][0] and mapmorpion[0][2]=="O" and mapmorpion[1][1] not in coup:
                    mapmorpionIA[1][1]=5

    max = -1
    for i in range(0,3):
        for j in range(0,3):
            if mapmorpionIA[i][j]>max:
                max=mapmorpionIA[i][j]
                choix=mapmorpion[i][j]
    sleep(1)
    return choix







def affichemap(): 
    os.system('CLS')
    for i in range (0,3):
        print(mapmorpion[i])

def ecrirechoix(choix,joueur):
    if joueur=="J1":
        if choix=="7" :
            mapmorpion[0][0]='X'
        if choix=="8" :
            mapmorpion[0][1]='X'
        if choix=="9" :
            mapmorpion[0][2]='X'
        if choix=="4" :
            mapmorpion[1][0]='X'
        if choix=="5" :
            mapmorpion[1][1]='X'
        if choix=="6" :
            mapmorpion[1][2]='X'
        if choix=="1" :
            mapmorpion[2][0]='X'
        if choix=="2" :
            mapmorpion[2][1]='X'
        if choix=="3" :
            mapmorpion[2][2]='X'
    if joueur=="J2":
        if choix=="7" :
            mapmorpion[0][0]='O'
        if choix=="8" :
            mapmorpion[0][1]='O'
        if choix=="9" :
            mapmorpion[0][2]='O'
        if choix=="4" :
            mapmorpion[1][0]='O'
        if choix=="5" :
            mapmorpion[1][1]='O'
        if choix=="6" :
            mapmorpion[1][2]='O'
        if choix=="1" :
            mapmorpion[2][0]='O'
        if choix=="2" :
            mapmorpion[2][1]='O'
        if choix=="3" :
            mapmorpion[2][2]='O'





def verifiechoix():
    for i in range(0,3):
        for j in range(0,3):
            if mapmorpion[i][j]==mapmorpion[i][j-2] and mapmorpion[i][j-2]==mapmorpion[i][j-1]:
                return True
            if mapmorpion[i][j]==mapmorpion[i-2][j] and mapmorpion[i-2][j]==mapmorpion[i-1][j]:
                return True
            if mapmorpion[0][0]==mapmorpion[1][1] and mapmorpion[1][1]==mapmorpion[2][2]:
                return True
            if mapmorpion[2][0]==mapmorpion[1][1] and mapmorpion[1][1]==mapmorpion[0][2]:
                return True



mode = ecranselec()
print (mode)
mode1 = int(mode/100)
mode2 = int((mode -mode1 * 100)/10)
mode3 = int((mode - (mode1*100) - (mode2*10)))
print(mode1)
print(mode2)
print(mode3)




# ------------DEBUT----------------

for i in range(0,4):
# ---------------JOUEUR 1---------------
    affichemap()
    if mode1 == 1 or mode1 == 2 and mode3 == 1:
        choix = input("ou veux tu jouer joueur 1: ")

        while not possible(choix):
            affichemap()
            choix = input("ou veux tu jouer joueur 1: ")
    if mode1 == 2 and mode3 == 2 or mode1 == 3:
        if mode2 == 1:
            choix = IAdrunk(listecoupjoue)
        if mode2 == 2:
            choix = FlavorIA(mapmorpion,mapmorpionIA,coup,1)
        if mode2 == 3:
            choix = FlavorIAnv2(mapmorpion,mapmorpionIA,coup,1)
        if mode2 == 4:
            pass




    ecrirechoix(choix, "J1")
    listecoupjoue.append(choix)
    if verifiechoix():
        affichemap()
        print("vicoire joueur 1")
        break
# -----------------JOUEUR 2------------------
    affichemap()
    if mode == 1 or mode1 == 2 and mode3 == 2:
        choix = input("ou veux tu jouer joueur 2: ")

        while not possible(choix):
            affichemap()
            choix = input("ou veux tu jouer joueur 2: ")
    if mode1 == 2 and mode3 == 1:
        if mode2 == 1:
            choix = IAdrunk(listecoupjoue)
        if mode2 == 2:
            choix = FlavorIA(mapmorpion,mapmorpionIA,coup,2)
        if mode2 == 3:
            choix = FlavorIAnv2(mapmorpion,mapmorpionIA,coup,2)
        if mode2 == 4:
            pass
    if mode1 == 3:
        if mode3 == 1:
            choix = IAdrunk(listecoupjoue)
        if mode3 == 2:
            choix = FlavorIA(mapmorpion,mapmorpionIA,coup,2)
        if mode3 == 3:
            choix = FlavorIAnv2(mapmorpion,mapmorpionIA,coup,2)
        if mode3 == 4:
            pass





    ecrirechoix(choix, "J2")
    listecoupjoue.append(choix)
    if verifiechoix():
        affichemap()
        print("vicoire IA")
        break

# --------------JOUEUR 1 FIN ------------------
if not verifiechoix():
    affichemap()
    if mode1 == 1 or mode1 == 2 and mode3 == 1:
        choix = input("ou veux tu jouer joueur 1: ")

        while not possible(choix):
            affichemap()
            choix = input("ou veux tu jouer joueur 1: ")
    if mode1 == 2 and mode3 == 2 or mode1 == 3:
        if mode2 == 1:
            choix = IAdrunk(listecoupjoue)
        if mode2 == 2:
            choix = FlavorIA(mapmorpion,mapmorpionIA,coup,1)
        if mode2 == 3:
            choix = FlavorIAnv2(mapmorpion,mapmorpionIA,coup,1)
        if mode2 == 4:
            pass

    ecrirechoix(choix, "J1")
    listecoupjoue.append(choix)
    if verifiechoix():
        affichemap()
        print("vicoire joueur 1")
    if not verifiechoix():
        affichemap()
        print("egalite")











