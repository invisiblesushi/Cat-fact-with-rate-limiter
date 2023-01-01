# Cat-fact-with-rate-limiter
Application to get data from catfact api with rate limiter.
Utilizing Polly libary and https://catfact.ninja/ api.

Application prints out a list of all cat breeds and some facts provided by the api, and throttles the rate limit to 2 requests pr 10 secounds.

```
Policy.RateLimitAsync(2, TimeSpan.FromSeconds(10));
```

Output:
```
Cat breeds:
Rate limited 00:00:03.9952155
Rate limited 00:00:04.8726715
Rate limited 00:00:04.8758951
Breed: Abyssinian
Country: Ethiopia
Origin: Natural/Standard
Coat: Short
Pattern: Ticked

Breed: Aegean
Country: Greece
Origin: Natural/Standard
Coat: Semi-long
Pattern: Bi- or tri-colored

Breed: American Curl
Country: United States
Origin: Mutation
Coat: Short/Long
Pattern: All

Breed: American Bobtail
Country: United States
Origin: Mutation
Coat: Short/Long
Pattern: All

Breed: American Shorthair
Country: United States
Origin: Natural
Coat: Short
Pattern: All but colorpoint

Breed: American Wirehair
Country: United States
Origin: Mutation
Coat: Rex
Pattern: All but colorpoint

Breed: Arabian Mau
Country: Arabian Peninsula
Origin: Natural
Coat: Short
Pattern:

Breed: Australian Mist
Country: Australia
Origin: Crossbreed
Coat: Short
Pattern: Spotted and Classic tabby

Breed: Asian
Country: developed in the United Kingdom (founding stock from Asia)
Origin:
Coat: Short
Pattern: Evenly solid

Breed: Asian Semi-longhair
Country: United Kingdom
Origin: Crossbreed
Coat: Semi-long
Pattern: Solid

Breed: Balinese
Country: developed in the United States (founding stock from Thailand)
Origin: Crossbreed
Coat: Long
Pattern: Colorpoint

Breed: Bambino
Country: United States
Origin: Crossbreed
Coat: Hairless/Furry down
Pattern:

Breed: Bengal
Country: developed in the United States (founding stock from Asia)
Origin: Hybrid
Coat: Short
Pattern: Spotted/Marbled

Breed: Birman
Country: developed in France (founding stock from Burma)
Origin: Natural
Coat: Semi Long
Pattern: Colorpoint

Breed: Bombay
Country: developed in the United States (founding stock from Asia)
Origin: Crossbred
Coat: Short
Pattern: Solid

Breed: Brazilian Shorthair
Country: Brazil
Origin: Natural
Coat: Short
Pattern: All

Breed: British Semi-longhair
Country: United Kingdom
Origin:
Coat: Medium
Pattern: All

Breed: British Shorthair
Country: United Kingdom
Origin: Natural
Coat: Short
Pattern: All

Breed: British Longhair
Country: United Kingdom
Origin:
Coat: Long
Pattern:

Breed: Burmese
Country: Burma and Thailand
Origin: Natural
Coat: Short
Pattern: Solid

Breed: Burmilla
Country: United Kingdom
Origin: Crossbreed
Coat: Short/Long
Pattern:

Breed: California Spangled
Country: United States
Origin: Crossbreed
Coat: Short
Pattern: Spotted

Breed: Chantilly-Tiffany
Country: United States
Origin:
Coat:
Pattern:

Breed: Chartreux
Country: France
Origin: Natural
Coat: Short
Pattern: Solid

Breed: Chausie
Country: France
Origin: Hybrid
Coat: Short
Pattern: Ticked

Breed: Cheetoh
Country: United States
Origin: Hybrid Crossbreed
Coat: Short
Pattern: Spotted

Breed: Colorpoint Shorthair
Country:
Origin:
Coat: Short
Pattern:

Breed: Cornish Rex
Country: United Kingdom (England)
Origin: Mutation
Coat: Rex
Pattern: All

Breed: Cymric or Manx Longhair
Country: United Kingdom (Isle of Man)
Origin: Natural/Mutation
Coat: Long
Pattern:

Breed: Cyprus
Country: Cyprus
Origin: Natural
Coat: All
Pattern: All

Breed: Devon Rex
Country: United Kingdom (England)
Origin: Mutation
Coat: Rex
Pattern: All

Breed: Donskoy, or Don Sphynx
Country: Russia
Origin:
Coat: Hairless
Pattern:

Breed: Dragon Li
Country: China
Origin: Natural
Coat: Short
Pattern: Striped tabby

Breed: Dwarf cat, or Dwelf
Country:
Origin: Crossbreed
Coat:
Pattern: Hairless

Breed: Egyptian Mau
Country: Egypt
Origin: Natural
Coat: Short
Pattern: Spotted

Breed: European Shorthair
Country: Finland and Sweden
Origin: Natural
Coat: Short
Pattern:

Breed: Exotic Shorthair
Country: United States
Origin: Crossbreed
Coat: Short
Pattern: All

Breed: Foldex[4]
Country: Canada
Origin: Crossbreed
Coat: Short
Pattern: All

Breed: German Rex
Country: East Germany
Origin: Mutation
Coat: Rex
Pattern:

Breed: Havana Brown
Country: United Kingdom
Origin:
Coat: Short
Pattern: Solid

Breed: Highlander
Country: United States
Origin: Crossbreed
Coat: Short/Long
Pattern: All

Breed: Himalayan, or Colorpoint Persian
Country: United States/United Kingdom
Origin: Crossbreed
Coat: Long
Pattern: Colorpoint

Breed: Japanese Bobtail
Country: Japan
Origin: Natural
Coat: Short/Long
Pattern: All but colorpoint and ticked

Breed: Javanese
Country: United States
Origin: Crossbreed
Coat: Long/Short
Pattern: Colorpoint

Breed: Karelian Bobtail
Country: Western Russia
Origin: Natural
Coat:
Pattern:

Breed: Khao Manee
Country: Thailand
Origin: Natural
Coat: Short
Pattern: Solid

Breed: Korat
Country: Thailand
Origin: Natural
Coat: Short
Pattern: Solid

Breed: Korean Bobtail
Country: Korea
Origin: Natural
Coat: Short/Long
Pattern: Colorprint

Breed: Korn Ja
Country: Thailand
Origin: Natural
Coat: Short/Hairless
Pattern: Solid

Breed: Kurilian Bobtail, or Kuril Islands Bobtail
Country: Eastern Russia,Japan
Origin: Natural
Coat: Short/Long
Pattern:

Breed: LaPerm
Country: United States
Origin: Mutation
Coat: Rex
Pattern: All

Breed: Lykoi
Country: United States
Origin: Natural/Mutation
Coat: Partly Hairless
Pattern: Ticked

Breed: Maine Coon
Country: United States
Origin: Natural
Coat: Long
Pattern: All but colorpoint and ticked

Breed: Manx
Country: United Kingdom (Isle of Man)
Origin: Mutation
Coat: Short/Long
Pattern: All but colorpoint

Breed: Mekong Bobtail
Country: Russia
Origin: Natural/Mutation
Coat: Short
Pattern: Colorpoint

Breed: Minskin
Country: United States
Origin: Crossbreed
Coat: Short/Hairless
Pattern: All

Breed: Munchkin
Country: United States
Origin: Mutation
Coat:
Pattern:

Breed: Nebelung
Country: United States
Origin:
Coat: Semi-long
Pattern: Solid

Breed: Napoleon
Country:
Origin:
Coat: Long/short
Pattern: Varied

Breed: Norwegian Forest cat
Country: Norway
Origin: Natural
Coat: Long
Pattern: All but colorpoint

Breed: Ocicat
Country: United States
Origin: Crossbreed
Coat: Short
Pattern: Spotted

Breed: Ojos Azules
Country: United States
Origin:
Coat:
Pattern:

Breed: Oregon Rex
Country: United States
Origin: Mutation
Coat: Rex
Pattern:

Breed: Oriental Bicolor
Country:
Origin:
Coat:
Pattern: Bicolor

Breed: Oriental Shorthair
Country:
Origin:
Coat: Short
Pattern: All but colorpoint

Breed: Oriental Longhair
Country:
Origin:
Coat: Semi-long
Pattern:

Breed: PerFoldæ(Experimental Breed - WCF)
Country: Europe
Origin: Crossbreed
Coat: Long
Pattern: All

Breed: Persian (Modern Persian Cat)
Country: Iran (Persia)
Origin: Crossbreed
Coat: Long
Pattern: All

Breed: Persian (Traditional Persian Cat)
Country: Greater Iran
Origin: Natural
Coat: Long
Pattern: All

Breed: Peterbald
Country: Russia
Origin: Crossbreed
Coat: Hairless
Pattern: All

Breed: Pixie-bob
Country: United States
Origin: Natural
Coat: Short
Pattern: Spotted

Breed: Raas
Country: Indonesia
Origin: Natural
Coat: Short
Pattern:

Breed: Ragamuffin
Country: United States
Origin: Crossbreed
Coat: Long
Pattern: All

Breed: Ragdoll
Country: United States
Origin: Crossbreed
Coat: Long
Pattern: Colorpoint/Mitted/Bicolor

Breed: Russian Blue
Country: Russia
Origin: Natural
Coat: Short
Pattern: Solid

Breed: Russian White, Black and Tabby
Country: Australia
Origin: Crossbreed
Coat: Short
Pattern:

Breed: Sam Sawet
Country: Thailand
Origin: Natural
Coat: Short
Pattern: Solid

Breed: Savannah
Country: United States
Origin: Hybrid
Coat: Short
Pattern: Spotted

Breed: Scottish Fold
Country: United Kingdom (Scotland)
Origin: Natural/Mutation
Coat: Short/Long
Pattern: All

Breed: Selkirk Rex
Country: United States
Origin: Mutation/Cross
Coat: Rex (Short/Long)
Pattern: All

Breed: Serengeti
Country: United States
Origin: Hybrid Crossbreed
Coat: Short
Pattern: Spotted

Breed: Serrade petit
Country: France
Origin: Natural
Coat: Short
Pattern:

Breed: Siamese
Country: Thailand
Origin: Natural
Coat: Short
Pattern: Colorpoint

Breed: Siberian
Country: Russia
Origin: Natural
Coat: Semi-long
Pattern: All

Breed: Singapura
Country: Singapore
Origin: Natural
Coat: Short
Pattern: Ticked

Breed: Snowshoe
Country: United States
Origin: Crossbreed
Coat: Short
Pattern: Colorpoint

Breed: Sokoke
Country: Kenya
Origin: Natural
Coat: Short
Pattern: Classic tabby with ticking

Breed: Somali
Country: Somalia
Origin: Mutation
Coat: Long
Pattern: Ticked

Breed: Sphynx
Country: Canada
Origin: Mutation
Coat: Hairless
Pattern: All

Breed: Suphalak
Country: Thailand
Origin: Natural
Coat: Short
Pattern: Solid

Breed: Thai
Country: Thailand
Origin: Natural
Coat: Short
Pattern: Colorpoint

Breed: Thai Lilac
Country: Thailand
Origin: Natural
Coat: Short
Pattern: Solid

Breed: Tonkinese
Country: Canada
Origin: Crossbreed
Coat: Short
Pattern: Colorpoint/Mink/Solid

Breed: Toyger
Country: United States
Origin: Crossbreed
Coat: Short
Pattern: Mackerel

Breed: Turkish Angora
Country: Turkey
Origin: Natural
Coat: Semi-long
Pattern: All but colorpoint

Breed: Turkish Van
Country: developed in the United Kingdom (founding stock from Turkey)
Origin: Natural
Coat: Semi-long
Pattern: Van

Breed: Ukrainian Levkoy
Country: Ukraine
Origin:
Coat: Hairless
Pattern:

Breed: York Chocolate
Country: United States (New York)
Origin: Natural
Coat: Long
Pattern: Solid

Cat facts:
Rate limited 00:00:04.8178384
Rate limited 00:00:04.8895576
Rate limited 00:00:04.8971815
Rate limited 00:00:04.8932917
Rate limited 00:00:04.8946342
Fact:    Baking chocolate is the most dangerous chocolate to your cat.
Fact:    The cat's clavicle, or collarbone, does not connect with other bones but is buried in the muscles of the shoulder region. This lack of a functioning collarbone allows them to fit through any opening the size of their head.
Fact:    A cat's nose pad is ridged with a unique pattern, just like the fingerprint of a human.
Fact:    Contrary to popular belief, the cat is a social animal. A pet cat will respond and answer to speech , and seems to enjoy human companionship.
Fact:    Abraham Lincoln loved cats. He had four of them while he lived in the White House.
```
