var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
import { Component } from '@angular/core';
import { DataServiceUser } from '../../data-service/data.service.user';
var ActiveUserListComponent = /** @class */ (function () {
    function ActiveUserListComponent(dataService) {
        this.dataService = dataService;
    }
    ActiveUserListComponent.prototype.ngOnInit = function () {
        this.load();
    };
    ActiveUserListComponent.prototype.load = function () {
        var _this = this;
        this.dataService.getActiveUsers().subscribe(function (data) { return _this.users = data; });
    };
    ActiveUserListComponent.prototype.delete = function (id) {
        var _this = this;
        this.dataService.deleteUser(id).subscribe(function (data) { return _this.load(); });
    };
    ActiveUserListComponent = __decorate([
        Component({
            templateUrl: '../user.template/user-list.component.html',
            styleUrls: ['../../style/app.component.css']
        }),
        __metadata("design:paramtypes", [DataServiceUser])
    ], ActiveUserListComponent);
    return ActiveUserListComponent;
}());
export { ActiveUserListComponent };
//# sourceMappingURL=user-ActiveList.component.js.map