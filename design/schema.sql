PRAGMA foreign_keys = ON;

CREATE TABLE IF NOT EXISTS notes (
	id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE,
	note TEXT DEFUALT NULL
	);

CREATE TABLE IF NOT EXISTS connections(
	source INTEGER NOT NULL,
	sink INTEGER NOT NULL,
	is_directional TINYINT(1) DEFAULT 0 CHECK (is_directional = 0 or is_directional = 1),
	comment TEXT DEFUALT NULL,
	FOREIGN KEY (source) REFERENCES notes(id),
	FOREIGN KEY (sink) REFERENCES notes(id)
	);
