DROP TABLE IF EXISTS "cricketdata";
CREATE TABLE "cricketdata" ("data" VARCHAR, "shotcount" INTEGER, "sessionid" INTEGER PRIMARY KEY  NOT NULL  UNIQUE , "grounded" INTEGER, "speed" INTEGER, "type" VARCHAR, "headbalance" INTEGER, "closetobody" INTEGER, "middleofthebat" FLOAT, "time" VARCHAR, "direction" VARCHAR);
