docker run --rm --env "TZ=Europe/Oslo" --name mariadb -p 3308:3306/tcp -v "$(pwd)/database":/var/lib/mysql -e MYSQL_ROOT_PASSWORD=1 -d mariadb:11.4
