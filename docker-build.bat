docker build -t e-stock-view .

heroku login
heroku container:login

docker tag e-stock-view registry.heroku.com/e-stock-view/web
docker push registry.heroku.com/e-stock-view/web

heroku container:release web -a e-stock-view