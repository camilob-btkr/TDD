
# 🎲 Yatzy (Traducción en Español)

> Basado en la descripción original disponible en:  
> https://sammancoaching.org/kata_descriptions/yatzy.html

---

El juego de Yatzy es un juego de dados simple. Cada jugador lanza cinco dados de seis caras. Pueden volver a lanzar algunos o todos los dados hasta tres veces (incluyendo el lanzamiento original).

El jugador luego asigna la tirada a una categoría, como unos, doses, cincos, par, dos pares, etc. (ver las reglas a continuación). Si la tirada es compatible con la categoría, el jugador obtiene una puntuación según las reglas. Si la tirada no es compatible con la categoría, el jugador obtiene cero puntos por esa tirada.

Por ejemplo, supongamos que un jugador obtiene 5, 6, 5, 5, 2 y lo coloca en la categoría “cincos”, entonces obtiene 15 (tres cincos). La puntuación de esa tirada se suma a su total, y la categoría ya no puede volver a usarse en las tiradas restantes de esa partida. Una partida completa consiste en una tirada por cada categoría. Por lo tanto, en su última tirada, un jugador debe elegir su única categoría restante.

Tu tarea es puntuar una **tirada dada** en una **categoría dada**.  
**No tienes que programar el lanzamiento aleatorio de los dados.**  
El juego **NO** se juega dejando que el ordenador elija la categoría que otorga la puntuación más alta para una tirada dada.

---

## 📂 Categorías de Yatzy y Reglas de Puntuación

### 🎯 Chance

El jugador obtiene la suma de todos los dados, sin importar qué valores tengan. Por ejemplo:

- 1,1,3,3,6 colocados en “chance” da 14 (1+1+3+3+6)  
- 4,5,5,6,1 colocados en “chance” da 21 (4+5+5+6+1)

---

### 🏆 Yatzy

Si todos los dados tienen el mismo número, el jugador obtiene 50 puntos. Por ejemplo:

- 1,1,1,1,1 colocados en “yatzy” da 50  
- 1,1,1,2,1 colocados en “yatzy” da 0

---

### 🔢 Ones, Twos, Threes, Fours, Fives, Sixes

El jugador obtiene la suma de los dados que tienen uno, dos, tres, cuatro, cinco o seis, respectivamente. Por ejemplo:

- 1,1,2,4,4 colocados en “fours” da 8 (4+4)  
- 2,3,2,5,1 colocados en “twos” da 4 (2+2)  
- 3,3,3,4,5 colocados en “ones” da 0

---

### 👯‍♂️ Pair

El jugador obtiene la suma del par coincidente más alto. Por ejemplo, colocados en “pair”:

- 1,2,3,4,5 da 0  
- 3,3,3,4,4 da 8 (4+4)  
- 1,1,6,2,6 da 12 (6+6)  
- 3,3,3,4,1 da 6 (3+3)  
- 3,3,3,3,1 da 6 (3+3)

---

### 👫 Two pairs

Si hay dos pares de dados con el mismo número, el jugador obtiene la suma de esos dados. Por ejemplo, colocados en “two pairs”:

- 1,1,2,3,3 da 8 (1+1+3+3)  
- 1,1,2,3,4 da 0  
- 1,1,2,2,2 da 6 (1+1+2+2)  
- 3,3,3,3,1 da 0

---

### 👨‍👩‍👦 Three of a kind

Si hay tres dados con el mismo número, el jugador obtiene la suma de esos dados. Por ejemplo, colocados en “three of a kind”:

- 3,3,3,4,5 da 9 (3+3+3)  
- 3,3,4,5,6 da 0  
- 3,3,3,3,1 da 9 (3+3+3)

---

### 💪 Four of a kind

Si hay cuatro dados con el mismo número, el jugador obtiene la suma de esos dados. Por ejemplo, colocados en “four of a kind”:

- 2,2,2,2,5 da 8 (2+2+2+2)  
- 2,2,2,5,5 da 0  
- 2,2,2,2,2 da 8 (2+2+2+2)

---

### 📈 Small straight

Colocados en “small straight”, si los dados muestran:

- 1,2,3,4,5

el jugador obtiene 15 (la suma de todos los dados).

---

### 📉 Large straight

Colocados en “large straight”, si los dados muestran:

- 2,3,4,5,6

el jugador obtiene 20 (la suma de todos los dados).

---

### 🏠 Full house

Si los dados contienen un trío y un par, el jugador obtiene la suma de todos los dados. Por ejemplo, colocados en “full house”:

- 1,1,2,2,2 da 8 (1+1+2+2+2)  
- 2,2,3,3,4 da 0  
- 4,4,4,4,4 da 0

---

## 🙏 Agradecimientos

Esta kata está descrita en [cyber-dojo.org](https://cyber-dojo.org) pero ha sido modificada ligeramente.
