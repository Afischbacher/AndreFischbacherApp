var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { NgModule } from '@angular/core';
import { AppToolbar } from './toolbar.component';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material';
import { MatTooltipModule } from '@angular/material/tooltip';
import { RouterModule } from '@angular/router';
var AppToolbarModule = /** @class */ (function () {
    function AppToolbarModule() {
    }
    AppToolbarModule = __decorate([
        NgModule({
            declarations: [
                AppToolbar
            ],
            imports: [
                MatIconModule,
                RouterModule,
                MatTooltipModule,
                MatToolbarModule
            ],
            providers: [],
            exports: [AppToolbar]
        })
    ], AppToolbarModule);
    return AppToolbarModule;
}());
export { AppToolbarModule };
//# sourceMappingURL=toolbar.module.js.map