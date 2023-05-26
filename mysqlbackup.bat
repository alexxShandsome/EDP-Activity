rem path to sql bin server
cd "C:\Program Files\MySQL\MySQL Server 8.0\bin"

rem backup file path
set backup_path=C:\Users\Algilbert\Desktop\EDP-Activity
set backup_name=edp_database.sql

rem backup creation
mysqldump -u algilbert -p edp_database --routines --events --result-file="%backup_path%\%backup_name%"
if %ERRORLEVEL% neq 0 (
    (echo Backup failed: error during dump creation) >> "%backup_path%\mysql_backup_log.txt"
) else (echo Backup susccessful) >> "%backup_path%\mysql_backup_log_.txt"