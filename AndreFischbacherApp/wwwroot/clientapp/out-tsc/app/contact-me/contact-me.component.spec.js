import { TestBed, async } from '@angular/core/testing';
import { ContactMeComponent } from './contact-me.component';
describe('ContactMeComponent', function () {
    beforeEach(async(function () {
        TestBed.configureTestingModule({
            declarations: [
                ContactMeComponent
            ],
        }).compileComponents();
    }));
    it('should create the app', async(function () {
        var fixture = TestBed.createComponent(ContactMeComponent);
        var app = fixture.debugElement.componentInstance;
        expect(app).toBeTruthy();
    }));
});
//# sourceMappingURL=contact-me.component.spec.js.map