**Instruction dutilisation**
ceci est un projet ASP.NET Librery est l'intermédiaire entre les deux API (PFE principale et secondaire)

le docier Data conteant:
**Data**
ApplicationDbconext.cs
et AppDbContexFacotry.cs
AppDbContext permet de définir les table a migrer
et AppDbContexFacotry permet a ef core (entity framework ORM) d'instencier dbcontext afin de génere les les migrations

**Enumes et Models**
contenant la strcuture des tables et attribut + Enumération associer 
pour des réson technique les enumération on une notation d'entier car ef core ne supporte pas les type complexe
et les transforme en type prémitif dans la base de donnée 

*Migrations*
docier conteaner des fichier générer automatiquement par ef core l'ors de la commande :
# dotnet ef migrations add nom_de_migration_devotrechoix
 (A NE PAS MODIFIER) conteient lhistorique des modification 


// Initialisation
P = 0
alpha = 0.3  // coefficient de lissage, entre 0 et 1
while(P < 0.7) {
    for(i = 0; i < 5; i++) {  // simulation de 5 secondes
        prediction = lecture_du_modeleLSTM()  // retourne 0 (low) ou 1 (high)
        // Mettre à jour P de manière récurrente :
        // P_new = alpha * prediction + (1 - alpha) * P_old
        P = alpha * prediction + (1 - alpha) * P
        // On peut aussi incrémenter Totalpredict et highpredict si besoin pour log,
        // mais le calcul est directement intégré dans P.
    }
    if (P >= 0.4 and P < 0.7) {
        return false  // avertissement mais pas encore d'alerte critique
    }
}
// Si on sort de la boucle, c'est que P >= 0.7
return true
//ici si on sort de la grande boucle englobante (while(P<0.7)) sa veut dire a coup sur P>0.7 dans ce cas on ne rapple pas le model 
return true ici le toujour dans le cas du _await le hub recois dans ce cas un true est donc le hib va appler un autre service OBUvehicule(si le poteur a un vehicule)sinon appler le service phone (si ke porteur est un piéton) les service OBU et phone vont a leur tour genenre les potion GPS correct dans le secteur les envoyé a update postion la reponse final de update postion est attent du par le await des hubProS et ubRespHop pour tansfere les postion GPS au front 


AnomalyDetectionService.cs

import tensorflow as tf
from tensorflow import keras
from tensorflow.keras import layers
import numpy as np
import matplotlib.pyplot as plt

# Vérifier si le GPU est activé
print("GPU disponible :", tf.config.list_physical_devices('GPU'))
