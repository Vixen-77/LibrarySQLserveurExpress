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

# Préparer Google Colab


1-**Active l’accélération GPU (facultatif, mais recommandé)**
 Va dans Exécution → Modifier le type d’exécution.
                    +
Sélectionne GPU (cela accélère l'entraînement du modèle).

2-**Importer les bibliothèques nécessaires**
Dans la première cellule, exécutez ceci :

import numpy as np
import pandas as pd
import tensorflow as tf
from tensorflow import keras
from tensorflow.keras import layers
from sklearn.model_selection import train_test_split
from sklearn.preprocessing import StandardScaler
from sklearn.metrics import classification_report
3-**Charger et préparer ton dataset (.csv)**
Téléchargez ton fichier CSV sur Colab
Exécute cette cellule pour importer ton fichier CSV :

from google.colab import files
uploaded = files.upload()
Une fenêtre s'ouvrira → sélectionne ton fichier .csv.

📌 Lire le dataset avec Pandas
python
Copier
Modifier
df = pd.read_csv("ton_fichier.csv")  # Remplace par le nom du fichier
df.head()  # Affiche les premières lignes
📌 Séparer les entrées et la sortie
python
Copier
Modifier
X = df.iloc[:, :-1].values  # 14 paramètres (colonnes 1 à 14)
y = df.iloc[:, -1].values   # Dernière colonne (0 = Low, 1 = High)
📌 Diviser en train/test (80/20)
python
Copier
Modifier
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2, random_state=42)
📌 Standardiser les données
python
Copier
Modifier
scaler = StandardScaler()
X_train = scaler.fit_transform(X_train)
X_test = scaler.transform(X_test)
4️⃣ Construire le modèle DNN
📌 Définir l’architecture
python
Copier
Modifier
model = keras.Sequential([
    layers.Dense(32, activation='relu', input_shape=(14,)),
    layers.Dense(16, activation='relu'),
    layers.Dense(8, activation='relu'),
    layers.Dense(8, activation='relu'),  # Retirer cette ligne si tu veux tester 32-16-8-1
    layers.Dense(1, activation='sigmoid')  # Classification binaire
])
📌 Compiler le modèle
python
Copier
Modifier
model.compile(optimizer='adam',
              loss='binary_crossentropy',
              metrics=['accuracy'])
5️⃣ Entraîner le modèle
Ajoute Early Stopping pour éviter l'overfitting :

python
Copier
Modifier
early_stopping = keras.callbacks.EarlyStopping(monitor='val_loss', patience=10, restore_best_weights=True)
📌 Lancer l’entraînement
python
Copier
Modifier
history = model.fit(X_train, y_train,
                    epochs=50,  # Augmente si besoin
                    batch_size=512,
                    validation_data=(X_test, y_test),
                    callbacks=[early_stopping])
6️⃣ Évaluer le modèle
📌 Voir la précision sur les données test
python
Copier
Modifier
test_loss, test_acc = model.evaluate(X_test, y_test)
print(f"Test Accuracy: {test_acc:.2%}")
📌 Afficher les métriques (Precision, Recall, F1-score)
python
Copier
Modifier
y_pred = (model.predict(X_test) > 0.5).astype(int)
print(classification_report(y_test, y_pred))
7️⃣ Sauvegarder le modèle (optionnel)
Si tu veux sauvegarder le modèle pour l'utiliser plus tard :

python
Copier
Modifier
model.save("mon_modele.h5")
Et pour le recharger :

python
Copier
Modifier
model = keras.models.load_model("mon_modele.h5")
🎯 Résumé des étapes
1️⃣ Ouvre Google Colab + active le GPU.
2️⃣ Importe les bibliothèques.
3️⃣ Charge et prétraite les données.
4️⃣ Définis et compiles le modèle DNN.
5️⃣ Entraîne le modèle avec Early Stopping.
6️⃣ Évalue la performance (accuracy + F1-score).
7️⃣ Sauvegarde le modèle (optionnel).

💡 Si ton modèle sur-apprend (overfitting), ajoute du dropout :

python
Copier
Modifier
layers.Dropout(0.3)
entre certaines couches.

Dis-moi si tu veux tester plusieurs architectures automatiquement ! 




const handleSubmit = async () => {
  const formData = new FormData();
  formData.append("Name", data.firstname);
  formData.append("LastName", data.lastname);
  formData.append("Email", data.email);
  formData.append("Password", data.password);
  formData.append("Adress", data.adress);
  formData.append("PostalCode", data.postalcode);
  formData.append("PhoneNumber", data.phonenumber);
  formData.append("DateOfBirth", data.dateofbirth.toISOString());

  if (data.image) {
    formData.append("IdentityFile", data.image); // fichier image
  }

  await axios.post("/api/signup", formData, {
    headers: {
      "Content-Type": "multipart/form-data"
    }
  });
};


//
public class PositionObject
{
    public int Id { get; set; } // toujours utile pour l'identifiant

    // Très important : noms identiques à ceux utilisés dans React Native
    public double Latitude { get; set; }     // Ex : 37.78825
    public double Longitude { get; set; }    // Ex : -122.4324

    // Facultatif : tu peux enrichir le marker
    public string Title { get; set; }        // "You are here"
    public string Description { get; set; }  // "Current position"
}
