#version 330 core
out vec4 FragColor;

in vec2 TexCoords;

uniform sampler2D texture1;

void main()
{
    vec4 light= vec4(3.0,1.0,5.0,1.0);
    vec4 texColor = texture(texture1, TexCoords);//
    if(texColor.a < 0.1)
        discard;
    FragColor = light *texColor;
}