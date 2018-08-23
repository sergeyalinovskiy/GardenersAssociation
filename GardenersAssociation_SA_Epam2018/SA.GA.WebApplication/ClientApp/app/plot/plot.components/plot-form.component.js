var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
import { Component, Input } from '@angular/core';
import { Plot } from '../../models/plot';
var PlotFormComponent = /** @class */ (function () {
    function PlotFormComponent() {
    }
    __decorate([
        Input(),
        __metadata("design:type", Plot)
    ], PlotFormComponent.prototype, "plot", void 0);
    PlotFormComponent = __decorate([
        Component({
            selector: "plot-form",
            templateUrl: '../plot.template/plot-form.component.html',
            styleUrls: ['../../style/app.component.css']
        })
    ], PlotFormComponent);
    return PlotFormComponent;
}());
export { PlotFormComponent };
//# sourceMappingURL=plot-form.component.js.map