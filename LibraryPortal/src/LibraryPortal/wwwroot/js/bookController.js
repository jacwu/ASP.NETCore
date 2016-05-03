"use strict";

(function () {
    angular.module("app-library")
        .controller("bookController", bookController);

    function bookController($scope, $http) {               

        

        $scope.init = function (type) {

            var url = "/api/book/";
            if (type > 0) {
                url += type;
            }

            $http.get(url).success(function (data) {
                $scope.books = data;

                $scope.books.forEach(function (entry) {
                    if (entry.status == 0) {
                        entry.message = "Return";
                    }
                    else {
                        entry.message = "Borrow";
                    }
                });

                $http.get("/api/bookcategory").success(function (data) {
                    $scope.bookcategory = data;

                    $scope.books.forEach(function (entry) {
                        $scope.bookcategory.forEach(function (cat) {
                            if (entry.type == cat.id) {
                                entry.typename = cat.name;

                            }
                        })
                    });

                })

            })

        }


        $scope.changeStatus = function (book) {

            // change to the following status
            var status = 0;
            if (book.status == 0) {
                status = 1;
            }
            $http.post("/api/bookoperation/" + book.id, status).success(function(data){
                if (book.status == 0) {
                    book.status = 1;
                    book.message = "Borrow";
                }
                else {
                    book.status = 0;
                    book.message = "Return";
                }
            })          
        }


        $scope.deleteBook = function (book) {            
            $http.delete("/api/bookoperation/" + book.id).success(function (data) {
                var i = 0;
                while (i < $scope.books.length) {
                    if ($scope.books[i].id == book.id) {
                        $scope.books.splice(i, 1);
                        break;
                    }
                    i++;
                }
            })                  
        }
    }



}())