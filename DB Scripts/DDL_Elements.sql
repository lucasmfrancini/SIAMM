CREATE TABLE "element" (
	"id"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	"name"	TEXT NOT NULL,
	"protons"	INTEGER NOT NULL,
	"neutrons"	INTEGER NOT NULL,
	"electrons"	INTEGER NOT NULL
);