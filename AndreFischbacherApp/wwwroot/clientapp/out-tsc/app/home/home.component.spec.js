import { TestBed, async } from '@angular/core/testing';
import { HomeComponent } from './home.component';
describe('HomeComponent', function () {
    beforeEach(async(function () {
        TestBed.configureTestingModule({
            declarations: [
                HomeComponent
            ],
        }).compileComponents();
    }));
    it('should create the app', async(function () {
        var fixture = TestBed.createComponent(HomeComponent);
        var app = fixture.debugElement.componentInstance;
        expect(app).toBeTruthy();
    }));
});
//# sourceMappingURL=home.component.spec.js.map