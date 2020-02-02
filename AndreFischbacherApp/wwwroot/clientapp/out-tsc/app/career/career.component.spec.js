import { TestBed, async } from '@angular/core/testing';
import { CareerComponent } from './career.component';
describe('CareerComponent', function () {
    beforeEach(async(function () {
        TestBed.configureTestingModule({
            declarations: [
                CareerComponent
            ],
        }).compileComponents();
    }));
    it('should create the app', async(function () {
        var fixture = TestBed.createComponent(CareerComponent);
        var app = fixture.debugElement.componentInstance;
        expect(app).toBeTruthy();
    }));
});
//# sourceMappingURL=career.component.spec.js.map